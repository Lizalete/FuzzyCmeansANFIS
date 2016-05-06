using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Neural
{
    public class Layer
    {
        int layerNumber = 0;
        Neuron[] neurons;
        double[] y;
       
        public double[] Y
        {
            get { 
                CalculateOutputs(); 
                return y; 
            }
        }

        public int LayerNumber
        {
            get { return layerNumber; }
            set { layerNumber = value; }
        }

        public Neuron[] Neurons
        {
            get { return neurons; }
        }

        //Layer constructor
        public Layer(int neuronCount, int weights, double learningRate)
        {
            neurons = new Neuron[neuronCount];
            for (int n = 0; n < neurons.Length; n++)
            {
                neurons[n] = new Neuron(weights, learningRate);
            }
        }

        public void SetPattern(double[] features)
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].Inputs = new double[features.Length];

                //ingresa cada feature 
                for (int f = 0; f < features.Length; f++)
                {
                    neurons[i].Inputs[f] = features[f];
                }
            }
        }

        //Calculate the output of the layer
        public void CalculateOutputs()
        {
            y = new double[neurons.Length];
            for (int n = 0; n < neurons.Length; n++)
            {
                y[n] = neurons[n].Y;
            }
        }

        public void AdjustWeights()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].AdjustWeights();
            }
        }
    }
}
