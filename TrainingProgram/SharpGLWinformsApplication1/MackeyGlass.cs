using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftCMeans;
using FuzzyC_Means;
using System.Collections;

namespace SharpGLWinformsApplication1
{
    public class MackeyGlass
    {
        void getFuzzyPoints(ArrayList pointList){
        
        }

        public static List<Point3D> FILL(double b, double g, int t, int number, int p)
        {
            double beta = b;
            double gamma = g;
            int tau = t;
            int N = number;
            int pow = p;
            int delay1 = 17; //    Y AXIS
            int delay2 = 34; //    Z AXIS   

            double mX, mY, mZ;//  CENTROID

            List<double> y = new List<double>();
            List<Point3D> myPoints = new List<Point3D>();

            y.Add(0.9697); y.Add(0.9699); y.Add(0.9794); y.Add(1.0003);
            y.Add(1.0319); y.Add(1.0703); y.Add(1.1076); y.Add(1.1352);
            y.Add(1.1485); y.Add(1.1482); y.Add(1.1383); y.Add(1.1234);
            y.Add(1.1072); y.Add(1.0928); y.Add(1.0820); y.Add(1.0756);
            y.Add(1.0739); y.Add(1.0759);

            for (int n = (tau+1) ; n < (N + 99); n++)
            {
                y.Add(y[n - 1] - (gamma * y[n - 1]) + (beta * y[n - tau]) / (1 + Math.Pow(y[n - tau], pow)));
            }

            y.RemoveRange(0, 99);

            mX = 0;
            mY = 0;
            mZ = 0;

            for (int i = delay2; i < y.Count; i++)
            {
                mX += y[i];
                mY += y[i - delay1];
                mZ += y[i - delay2];
                myPoints.Add(new Point3D((float)y[i], (float)y[i - delay1], (float)y[i - delay2]));
            }

            mX /= myPoints.Count;
            mY /= myPoints.Count;
            mZ /= myPoints.Count;

            myPoints.Clear();
            Point3D pt = new Point3D(0, 0, 0);
            for (int i = delay2; i < y.Count; i++)
            {
                pt = new Point3D((float)(y[i] - mX), (float)(y[i - delay1] - mY), (float)(y[i - delay2] - mZ));
                pt.Tag = new Point3D((float)(y[i] - mX), (float)(y[i - delay1] - mY), (float)(y[i - delay2] - mZ));
                //pt.Tag = new Point3D(.5f, .5f, .5f);
                myPoints.Add(pt);                
            }
            return myPoints;
        }
    }
}
