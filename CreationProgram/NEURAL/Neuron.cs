using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Neural
{
    public class Neuron
    {
        #region Properties
        private double[] inputs;
        private double[] weights;
        private double outputY;
        private double bias;
        private double error;
        private double learningRate;
        private int size;
        private static Random rand = new Random();
        #endregion

        #region Fields
        //public double LearningRate
        //{
        //    get { return learningRate; }
        //}

        public double ErrorDelta
        {
            get { return error; }
            set { error = value; }
        }

        public double[] Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }
        public double Y
        {
            get
            {
                outputY = Output();
                return outputY;
            }
        }

        public double DerivY
        {
            get
            {
                outputY = Output();
                return SigmoidDerivative(outputY);
            }
        }

        public double Bias
        {
            get { return bias; }
            set { bias = value; }
        }

        //public int Size
        //{
        //    get { return size; }
        //}

        public double[] Weights
        {
            get { return weights; }
            set { weights = value; }
        }

        #endregion

        //so there wont be a problem
        public Neuron(int weightsNumber,double learningRate)
        {
            InitializeWeights(weightsNumber);
            this.learningRate = learningRate;
        }

        private void InitializeWeights(int weightsNumber)
        {
            this.weights = new double[weightsNumber];
            int i = 0;
            while(i < weightsNumber)
            {
                this.weights[i] = rand.NextDouble()-0.5;
                i++;
            }

            this.bias = rand.NextDouble() -0.5;
            this.size = weights.Length;
            Thread.Sleep(10);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        //there needs to be a complete with bias vector
        //so there wont be a problem
        public Neuron(double[] weights, double bias)
        {
            this.weights = weights;
            this.size = weights.Length;
            this.bias = bias;
        }
      
        public double Sumation(double[] input)
        {
            if (input == null)
                return 0;

            if (input.Length != this.size)
                return 0;

            double sumation = 0;
            int i = 0;
            while( i < size)
            {
                sumation += this.weights[i] * input[i];
                i++;
            }

            return sumation+bias;
        }

        private double Output()
        {
            double sum = Sumation(inputs);
            return Sigmoid(sum);
        }

        private double CalculateIncrement(int i)
        {
            return -(error * inputs[i] * learningRate);
        }

        private double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        private double SigmoidDerivative(double x)
        {
            return x * (1 - x);
        }

        public void AdjustWeights()
        {
            int i = 0;
            while( i < weights.Length)
            {
                weights[i] += CalculateIncrement(i);
                i++;
            }

            bias -= error * learningRate;
        }
    }
}
