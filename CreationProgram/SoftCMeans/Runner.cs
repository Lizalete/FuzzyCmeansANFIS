using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyC_Means
{
    public class Runner
    {
        static void execute(string[] args)
        {

            var points = new ArrayList();

            points.Add(new ClusterPoint(0.58, 0.33, 1));
            points.Add(new ClusterPoint(0.90, 0.11, 1));
            points.Add(new ClusterPoint(0.68, 0.17, 1));
            points.Add(new ClusterPoint(0.11, 0.44, 1));
            points.Add(new ClusterPoint(0.47, 0.81, 1));
            points.Add(new ClusterPoint(0.24, 0.83, 1));
            points.Add(new ClusterPoint(0.09, 0.18, 1));
            points.Add(new ClusterPoint(0.82, 0.11, 1));
            points.Add(new ClusterPoint(0.65, 0.50, 1));
            points.Add(new ClusterPoint(0.09, 0.63, 1));
            points.Add(new ClusterPoint(0.98, 0.24, 1));           

            var centroids = new ArrayList();

            centroids.Add(new ClusterCentroid(0.11, 0.44, 1));
            centroids.Add(new ClusterCentroid(0.82, 0.11, 1));//*/

            CMeansAlgorithm algorithm = new CMeansAlgorithm(points, centroids, 2);
            //int iterations = 12;alg.Run(Math.Pow(10, -5));

            double[,] Matrix = CMeansAlgorithm.U;

            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < centroids.Count; i++)
                {
                    var p = (ClusterPoint)points[j];
                    Console.WriteLine("{0:00} Point: ({1};{2}) ClusterIndex: {3} Value: {4:0.0000}", j + 1, p.X, p.Y, p.ClusterIndex, Matrix[j, i]);
                }
            }

            Console.WriteLine();
            //Console.WriteLine("Iteration count: {0}", iterations);
            Console.WriteLine();
            Console.WriteLine("Please press any key to exit...");
            Console.ReadLine();
        }
    }
}
