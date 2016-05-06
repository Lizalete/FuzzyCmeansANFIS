using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Neural;

namespace SharpGLWinformsApplication2
{
    class BackPoint
    {
        static Random ran = new Random();
        static double[] mask = new double[100];
        static double[] output;
        static Input input;
        static List<double[]> listOutput = new List<double[]>();

        public static List<double[]> FillList(NeuralNetwork nn)
        {
            for (int j = 0; j < 2000; j++)
            {
                for (int i = 0; i < 100; i++)
                {
                    mask[i] =ran.NextDouble();
                }
                input = new Input(mask, null);
                nn.SetPattern(input);
                output = nn.CalculateNetworkOutput();
                listOutput.Add(output);
            }
            return listOutput;
        }
    }
}
