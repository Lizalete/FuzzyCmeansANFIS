using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Neural
{
    public enum ActivationFunction
    {
        SIGMOID,
        SIGMOID_ORIGINAL
    }

    public class NeuralNetwork
    {
        Layer[] layers;
        private double[] networkOutput;
        Input input;
        double learningRate;
        private static Random random;

        public double LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }

        float error = 0;

        public Layer[] Layers
        {
            get { return layers; }
        }

        public double[] NetworkOutput
        {
            get { return networkOutput; }
        }

        public float Error
        {
            get { return error; }
        }

        public NeuralNetwork(string file)
        {
            LoadNetwork(file);
        }

        public NeuralNetwork(int neurons, int layersN, double learningRate, int features,int outputs)
        {
            this.layers = new Layer[layersN];
            this.learningRate = learningRate;

            layers[0] = new Layer(neurons, features, learningRate);

            for (int l = 1; l < layersN - 1; l++)
            {
                layers[l] = new Layer(neurons, neurons, learningRate);      // HIDDEN LAYERS
            }
            layers[layersN - 1] = new Layer(outputs, neurons, learningRate);
        }

        public NeuralNetwork(int neurons,int layersN,double learningRate,Input sample)
        {
            this.layers = new Layer[layersN+2];// 2 = input and output
            this.learningRate = learningRate;            

            layers[0] = new Layer(neurons, sample.Features.Length, learningRate);//INPUT
            int count = 0;
            //for (int l = 1; l < layersN - 1; l++)
            while(count<layersN)
            {
                layers[1+count] = new Layer(neurons, neurons, learningRate);      // HIDDEN LAYERS
                count++;
            }

            layers[layers.Length - 1] = new Layer(sample.DesiredValue.Length, neurons, learningRate); //OUTPUT
        }

        //Contructor of network, receives declared layers
        public NeuralNetwork(Layer[] layers)
        {
            this.layers = layers;
            for (int i = 0; i < layers.Length; i++)
                this.layers[i].LayerNumber = i;
        }

        //STEP ONE
        public void WeightInit()
        {
        }

        //STEP TWO : SET EACH PATTERN 
        public float SetPatterns(Input[] inputs)
        {
            //batch mode would be here
            double batchError;
            Random rand;
            int index,patterns;
            double[] test;

            test = new double[inputs.Length];
            rand = new Random();
            batchError = 0;

            patterns = 0;
            while (patterns < inputs.Length)
            {
                //index = rand.Next(0, inputs.Length - 1);
                //SetPattern(inputs[index]);
                SetPattern(inputs[patterns]);//HERE WE COULD USE RANDOM PATTERNS INSTEAD

                this.CalculateNetworkOutput();
                //BATCH is base on the sumation of all ONLINE MODES
                test[patterns] = this.CalculateError();
                batchError += test[patterns];

                this.CalculateDeltaError();
                this.AdjustWeights();
                patterns++;
            }
            
            error = ((float)batchError * 100) / inputs.Length;
            return error;
        }

        //STEP TWO : SET EACH PATTERN 
        public float SetPatternsRandom(Input[] inputs)
        {
            //batch mode would be here
            double batchError;
            Random rand;
            int index,patterns;
            double[] test;

            test = new double[inputs.Length];
            rand = new Random();
            batchError = 0;

            patterns = 0;
            while (patterns < inputs.Length)
            {
                index = rand.Next(0, inputs.Length - 1);
                SetPattern(inputs[index]);//HERE WE COULD USE RANDOM PATTERNS INSTEAD

                this.CalculateNetworkOutput();
                //BATCH is base on the sumation of all ONLINE MODES
                test[patterns] = this.CalculateError();
                batchError += test[patterns];

                this.CalculateDeltaError();
                this.AdjustWeights();
                patterns++;
            }
            
            error = ((float)batchError * 100) / inputs.Length;
            return error;
        }

        public void SetPattern(Input input)
        {
            this.input = input;
            layers[0].SetPattern(input.Features);       //Feature vector in input layer

            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].SetPattern( layers[i-1].Y );    //Inputs to hidden layers we just need final outputs
            }
        }

        //STEP THREE
        public double[] CalculateNetworkOutput()
        {
            networkOutput = layers[layers.Length-1].Y;  //Salida de las neuronas de la última capa
            return networkOutput;
        }

        public double CalculateError()
        {
            double error = 0;
            double[] desiredValue = input.DesiredValue;          

            for (int i = 0; i < networkOutput.Length; i++)
            {
                error += Math.Pow((networkOutput[i] - desiredValue[i]), 2);
            }

            return error; 
        }

        //STEP FOUR
        public void CalculateDeltaError()
        {
            double finalYDerivative = 0;
            double diff = 0;

            //last layer calculation
            for (int i = 0; i < layers[layers.Length - 1].Neurons.Length; i++)//cada neurona de la última capa
            {
                finalYDerivative = Util.SigmoidDerivative(networkOutput[i]);      //derivada de la salida
                diff = (networkOutput[i] - this.input.DesiredValue[i]);           //CÓMO VA LA RESTAAAA

                layers[layers.Length - 1].Neurons[i].ErrorDelta = finalYDerivative * diff;   //final delta
            }

            //hidden layers delta calculation
            Neuron next = null;
            Neuron current = null;

            for (int i = layers.Length - 2; i >= 0; i--)//desde la penultima a la primera
            {
                for (int neurons = 0; neurons < layers[i].Neurons.Length; neurons++)//cada neurona de la capa
                {
                    for (int extNeurons = 0; extNeurons < layers[i + 1].Neurons.Length; extNeurons++)
                    {
                        current = layers[i].Neurons[neurons];       //neurona a la que se le calcula el delta
                        next = layers[i + 1].Neurons[extNeurons];   //neurona de la siguiente capa

                        current.ErrorDelta = current.DerivY * next.ErrorDelta * next.Weights[neurons];
                    }
                }
            }
        }

        //STEP FIVE
        public void AdjustWeights()
        {
            for (int i = layers.Length-1; i >= 0; i--)
                layers[i].AdjustWeights();
        }

        public void SaveNetwork(string fileName)
        {
            // create a writer and open the file
            TextWriter textWriter = new StreamWriter(fileName+".NN");

            textWriter.WriteLine(this.learningRate);
            textWriter.WriteLine(this.error);
            textWriter.WriteLine(layers.Length);//layersN
            textWriter.WriteLine(layers[0].Neurons.Length); // neurons
            textWriter.WriteLine(layers[0].Neurons[0].Weights.Length);//features
            textWriter.WriteLine(layers[layers.Length-1].Neurons.Length);//outputs

            for (int i = 0; i < layers.Length; i++)//recorre capas
            {
                for (int j = 0; j < layers[i].Neurons.Length; j++)//recorre neuronas
                {
                    for (int w = 0; w < layers[i].Neurons[j].Weights.Length; w++)//recorre pesos
                    {
                        // write a line of text to the file
                        textWriter.WriteLine(layers[i].Neurons[j].Weights[w]);
                    }
                    textWriter.WriteLine(layers[i].Neurons[j].Bias);
                }

                textWriter.WriteLine();
            }
            // close the stream
            textWriter.Close();                        
        }
        
        public void LoadNetwork(string network)
        {
            TextReader textReader = new StreamReader(network);

            this.learningRate = double.Parse(textReader.ReadLine());
            this.error= float.Parse(textReader.ReadLine());

            int layersN = int.Parse(textReader.ReadLine());
            int neurons = int.Parse(textReader.ReadLine());
            int features = int.Parse(textReader.ReadLine());
            int outputs = int.Parse(textReader.ReadLine());
            
            
            this.layers = new Layer[layersN];

            layers[0] = new Layer(neurons, features, learningRate);
            for (int l = 1; l < layersN - 1; l++)
            {
                layers[l] = new Layer(neurons, neurons, learningRate);      // HIDDEN LAYERS
            }
            layers[layersN - 1] = new Layer(outputs, neurons, learningRate);

            for (int i = 0; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].Neurons.Length; j++)
                {
                    for (int w = 0; w < layers[i].Neurons[j].Weights.Length; w++)
                    {
                        // write a line of text to the file
                        layers[i].Neurons[j].Weights[w] = double.Parse(textReader.ReadLine());

                    }
                    layers[i].Neurons[j].Bias= double.Parse(textReader.ReadLine());
                }
                string str = textReader.ReadLine();//el espacio que separa cada capa
            }

            textReader.Close();
        }
    }
}
