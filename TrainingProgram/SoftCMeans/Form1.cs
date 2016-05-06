using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyC_Means;
using System.Collections;
using System.Diagnostics;

namespace SoftCMeans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClusterPoint p;
            var points = new ArrayList();
            var centroids = new ArrayList();

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

            centroids.Add(new ClusterCentroid(0.11, 0.44, .5));
            centroids.Add(new ClusterCentroid(0.82, 0.11, .25));

            CMeansAlgorithm algorithm = new CMeansAlgorithm(points, centroids, 2);

            string str = string.Empty;
            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < centroids.Count; i++)
                {
                    p = (ClusterPoint)points[j];
                    str = "\r\n " + j 
                        + " Point (" + p.ToString() + ") :IN: -+  "
                        + i + " |:| " + p.ClusterIndex + " - "
                        + CMeansAlgorithm.U[j, i]//j point index i centroid index
                        + " |C:| " + centroids[i].ToString();
                    textBox1.Text += str;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = new string[CMeansAlgorithm.U.Length];
            for (int j = 0; j < CMeansAlgorithm.U.GetLength(0); j++)
            {
                for (int i = 0; i < CMeansAlgorithm.U.GetLength(1); i++)
                {
                    lines[j] += " " + CMeansAlgorithm.U[j,i].ToString();
                }
            }
            System.IO.File.WriteAllLines(@"Puntos-" + lines.Length + ".txt", lines);
        }
    }
}
