using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGLWinformsApplication1
{
    class KMeans
    {
        double min;
        Point3D median;
        private List<Point3D> centroidList = new List<Point3D>();
        private List<Point3D> list = new List<Point3D>();
   
        public KMeans(List<Point3D> list)
        {
            Point3D ptTemp;
            for (int i = 0; i < list.Count; i++)
            {
                ptTemp = new Point3D(list[i].X, list[i].Y, list[i].Z);
                this.list.Add(ptTemp);
            }
        }

        public List<Point3D> Execute(int numberClusters)
        {
            Random ran = new Random();
            int r = 0;
            Point3D ptTemp;

            for (int i = 0; i < numberClusters; i++)
            {
                r = ran.Next(0, list.Count);
                ptTemp = list[r];
                centroidList.Add(ptTemp);               
            }

            for (int repeat = 0; repeat < 15; repeat++)
                AssignMedian();

            return centroidList;
        }
           
        Point3D ClosestMedian(Point3D point)
        {
            double d2;
            Point3D centroidTmp;

            min = double.MaxValue;

            for (int i = 0; i < centroidList.Count; i++)
            {
                centroidTmp = centroidList[i];                
                d2 = EuclideanDistancePoint(centroidTmp, point);

                if (d2 < min)
                {
                    min = d2;
                    median = centroidTmp;
                    median.ClusterIndex = i;
                }
            }
            return median;
        }
            
        double EuclideanDistancePoint(Point3D p, Point3D e)
        {
            double d = 0;
            d = Math.Pow(p.X - e.X, 2) + Math.Pow(p.Y - e.Y, 2) + Math.Pow(p.Z - e.Z, 2);
            return Math.Sqrt(d);
        }

        Point3D calculateCentroid(List<Point3D> list)
        {
            Point3D centroid;

            centroid = new Point3D(0, 0, 0);
            for (int i = 0; i < list.Count; i++)
            {
                centroid.X += list[i].X;
                centroid.Y += list[i].Y;
                centroid.Z += list[i].Z;
            }
            if (list.Count > 0)
            {
                centroid.X /= list.Count;
                centroid.Y /= list.Count;
                centroid.Z /= list.Count;
            }

            return centroid;
        }

        void AssignMedian()
        {
            Point3D point;
            Point3D closestCentroid;
            List<Point3D> tmp;
            Random random = new Random();

            tmp = new List<Point3D>();
            for (int i = 0; i < this.list.Count; i++ )
            {
                closestCentroid = ClosestMedian(list[i]);
                this.list[i].ClusterIndex = closestCentroid.ClusterIndex;
                this.centroidList[closestCentroid.ClusterIndex].Points.Add(this.list[i]);
            } 

            for (int c = 0; c < centroidList.Count; c++)
            {
                if (this.centroidList[c].Points.Count > 0)
                {
                    point = calculateCentroid(this.centroidList[c].Points);
                    point.Tag = new Point3D(random.NextDouble(), random.NextDouble(), random.NextDouble());
                    tmp.Add(point);
                }
            }

            this.centroidList.Clear();
            this.centroidList.AddRange(tmp);
        }
    }
}
