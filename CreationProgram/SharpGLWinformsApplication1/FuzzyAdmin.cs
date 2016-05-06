﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using FuzzyC_Means;
using System.Drawing;
using System.Threading;

namespace SharpGLWinformsApplication1
{
    class FuzzyAdmin
    {
        private static List<Point3D> listCentroids = new List<Point3D>();
        private ArrayList points = new ArrayList();
        private static CMeansAlgorithm algorithm;
        private  List<Point3D> list;

        public static CMeansAlgorithm Fuzzy
        {
            get { return FuzzyAdmin.algorithm; }
        }

        public FuzzyAdmin(List<Point3D> list)
        {
            this.list = list;
            for (int i = 0; i < list.Count; i++)
                points.Add(new ClusterPoint(list[i].X, list[i].Y, list[i].Z));
        }

        public void Execute(List<Point3D> listCentroids)
        {
            ClusterPoint centroid;
            ArrayList centroids = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < listCentroids.Count; i++)
            {
                centroid = new ClusterCentroid(listCentroids[i].X, listCentroids[i].Y, listCentroids[i].Z);

                if (listCentroids[i].Tag != null)
                    centroid.Tag = new ClusterCentroid(((Point3D)listCentroids[i].Tag).X, ((Point3D)listCentroids[i].Tag).Y, ((Point3D)listCentroids[i].Tag).Z);
                else
                    centroid.Tag = new ClusterCentroid(random.NextDouble(), random.NextDouble(), random.NextDouble());
                
                centroids.Add(centroid);
                listCentroids[i].Tag = new Point3D(((ClusterCentroid)centroid.Tag).X,((ClusterCentroid)centroid.Tag).Y,((ClusterCentroid)centroid.Tag).Z);
            }

            algorithm = new CMeansAlgorithm(points, centroids, 2);
            for (int j = 0; j < points.Count; j++)
            {
                ((Point3D)this.list[j].Tag).X = 0f;
                ((Point3D)this.list[j].Tag).Y = 0f;
                ((Point3D)this.list[j].Tag).Z = 0f;
            }
            Thread.Sleep(5000);

            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < centroids.Count; i++)
                {
                    ((Point3D)this.list[j].Tag).X += (((ClusterCentroid)((ClusterCentroid)centroids[i]).Tag).X * CMeansAlgorithm.U[j, i]);
                    ((Point3D)this.list[j].Tag).Y += (((ClusterCentroid)((ClusterCentroid)centroids[i]).Tag).Y * CMeansAlgorithm.U[j, i]);
                    ((Point3D)this.list[j].Tag).Z += (((ClusterCentroid)((ClusterCentroid)centroids[i]).Tag).Z * CMeansAlgorithm.U[j, i]);
                }
            }

            GC.Collect();
        }

        public static void SaveFuzzy() {
            string[] lines = new string[CMeansAlgorithm.U.GetLength(0)];
            int m = 0;
            for (int j = 0; j < CMeansAlgorithm.U.GetLength(0); j++)
            {
                for (int i = 0; i < CMeansAlgorithm.U.GetLength(1) - 1; i++)
                {
                    m = i;
                    lines[j] += CMeansAlgorithm.U[j, i].ToString() + " ";
                }
                lines[j] += CMeansAlgorithm.U[j, m + 1].ToString();
            }
            System.IO.File.WriteAllLines(@"Fuzzy-" + lines.Length + ".txt", lines);
        }

    }
}
