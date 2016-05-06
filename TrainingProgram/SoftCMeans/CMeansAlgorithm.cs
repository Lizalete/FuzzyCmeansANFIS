using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FuzzyC_Means
{
    public sealed class CMeansAlgorithm
    {
        ///
        /// Array containing all points used by the algorithm
        ///
        private static ArrayList Points;

        ///
        /// Array containing all clusters handled by the algorithm
        ///
        private static ArrayList Clusters;

        ///
        /// Gets or sets membership matrix
        ///
        public static double[,] U;

        ///
        /// Gets or sets the current fuzzyness factor
        ///
        private double Fuzzyness;

        ///
        /// Algorithm precision
        ///
        private double Eps = Math.Pow(10, -5);

        ///
        /// Gets or sets objective function
        ///
        private double J { get; set; }

        ///
        /// Gets or sets log message
        ///
        public string Log { get; set; }

        ///
        /// Initialize the algorithm with points and initial clusters
        ///

        /// Points
        /// Clusters
        /// The fuzzyness factor to be used
        /// 

        public CMeansAlgorithm(int numberPoints, int numberClusters, float fuzzy)
        {
            GC.Collect();
            /*if (points == null)
            {
                throw new ArgumentNullException("points");
            }

            if (clusters == null)
            {
                throw new ArgumentNullException("clusters");
            }

            Points = points;
            Clusters = clusters;*/

            if (U == null)
                U = new double[numberPoints, numberClusters];
            else
                if (U.LongLength != numberPoints * numberClusters)
                    U = new double[numberPoints, numberClusters];

            Fuzzyness = fuzzy;
        }

        public CMeansAlgorithm(ArrayList points, ArrayList clusters, float fuzzy)
        {
            GC.Collect();
            if (points == null)
            {
                throw new ArgumentNullException("points");
            }

            if (clusters == null)
            {
                throw new ArgumentNullException("clusters");
            }

            Points = points;
            Clusters = clusters;

            if(U==null)
                U = new double[Points.Count, Clusters.Count];
            else
                if(U.LongLength != points.Count*clusters.Count)
                    U = new double[Points.Count, Clusters.Count];

            Fuzzyness = fuzzy;

            double diff;

            // Iterate through all points to create initial U matrix
            for (int i = 0; i < Points.Count; i++)
            {
                var p = (ClusterPoint) Points[i];
                double sum = 0.0;

                for (int j = 0; j < Clusters.Count; j++)
                {
                    var c = (ClusterCentroid)Clusters[j];
                    diff = CalculateEulerDistance(p, c);
                    U[i, j] = (diff == 0) ? Eps : diff;
                    sum += U[i, j];
                }

                double sum2 = 0.0;
                for (int j = 0; j < Clusters.Count; j++)
                {
                    U[i, j] = 1.0 / Math.Pow(U[i, j] / sum, 2.0 / (Fuzzyness - 1.0));
                    sum2 += U[i, j];
                }

                for (int j = 0; j < Clusters.Count; j++)
                {
                    U[i, j] = U[i, j] / sum2;
                }
            }

            this.RecalculateClusterIndexes();
        }

        ///
        /// Recalculates cluster indexes
        ///
        private void RecalculateClusterIndexes()
        {
            for (int i = 0; i < Points.Count; i++)
            {
                double max = -1.0;
                var p = (ClusterPoint)Points[i];

                for (int j = 0; j < Clusters.Count; j++)
                {
                    if (max < U[i, j])
                    {
                        max = U[i, j];
                        p.ClusterIndex = (max == 0.5) ? 0.5 : j;
                    }
                }
            }
        }

        /// Perform one step of the algorithm
        ///
        public void Step()
        {
            for (int c = 0; c < Clusters.Count; c++)
            {
                for (int h = 0; h < Points.Count; h++)
                {
                    double top = CalculateEulerDistance((ClusterPoint)Points[h], (ClusterCentroid)Clusters[c]);
                    if (top < 1.0) top = Eps;

                    // Bottom is the sum of distances from this data point to all clusters.
                    double sumTerms = 0.0;
                    for (int ck = 0; ck < Clusters.Count; ck++)
                    {
                        double thisDistance = CalculateEulerDistance((ClusterPoint)Points[h], (ClusterCentroid)Clusters[ck]);
                        if (thisDistance < 1.0) thisDistance = Eps;
                        sumTerms += Math.Pow(top / thisDistance, 2.0 / (this.Fuzzyness - 1.0));
                    }

                    // Then the MF can be calculated as...
                    U[h, c] = (double)(1.0 / sumTerms);
                }
            }

            this.RecalculateClusterIndexes();
        }

        ///

        /// Calculates Euler's distance between point and centroid
        ///
        /// Point
        /// Centroid
        /// Calculated distance
        private double CalculateEulerDistance(ClusterPoint p, ClusterCentroid c)
        {
            return Math.Sqrt(Math.Pow(p.X - c.X, 2) + Math.Pow(p.Y - c.Y, 2) + Math.Pow(p.Z - c.Z, 2));
        }

        ///
        /// Calculate the objective function
        ///
        /// 
        /// 
        /// The objective function as double value
        private double CalculateObjectiveFunction()
        {
            double Jk = 0;

            for (int i = 0; i < Points.Count; i++)
            {
                for (int j = 0; j < Clusters.Count; j++)
                {
                    Jk += Math.Pow(U[i, j], this.Fuzzyness) * Math.Pow(this.CalculateEulerDistance((ClusterPoint)Points[i], (ClusterCentroid)Clusters[j]), 2);
                }
            }
            return Jk;
        }

        ///
        /// Calculates the centroids of the clusters 
        ///
        private void CalculateClusterCenters()
        {
            for (int j = 0; j < Clusters.Count; j++)
            {
                var c = (ClusterCentroid) Clusters[j];
                double uX = 0.0;
                double uY = 0.0;
                double uZ = 0.0;
                double l = 0.0;

                for (int i = 0; i < Points.Count; i++)
                {
                    var p = (ClusterPoint) Points[i];

                    double uu = Math.Pow(U[i, j], this.Fuzzyness);
                    uX += uu * c.X;
                    uY += uu * c.Y;
                    uZ += uu * c.Z;
                    l += uu;
                }

                c.X = ((int)(uX / l));
                c.Y = ((int)(uY / l));
                c.Z = ((int)(uZ / l));

                this.Log += string.Format("Cluster Centroid: ({0}; {1}; {2};)" + System.Environment.NewLine, c.X, c.Y,c.Z);
            }
        }

        ///
        /// Perform a complete run of the algorithm until the desired accuracy is achieved.
        /// For demonstration issues, the maximum Iteration counter is set to 20.
        ///

        /// Algorithm accuracy
        /// The number of steps the algorithm needed to complete
        public int Run(double accuracy)
        {
            int i = 0;
            int maxIterations = 20;
            do
            {
                i++;
                this.J = this.CalculateObjectiveFunction();
                this.CalculateClusterCenters();
                this.Step();
                double Jnew = this.CalculateObjectiveFunction();
                if (Math.Abs(this.J - Jnew) < accuracy) break;
            }
            while (maxIterations > i);
            return i;
        }
    }

}
