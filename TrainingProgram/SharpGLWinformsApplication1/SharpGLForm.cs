using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using System.Threading;
using FuzzyC_Means;
using System.Collections;

namespace SharpGLWinformsApplication1
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class SharpGLForm : Form
    {
        private static List<Point3D> mackey = new List<Point3D>();

        public static List<Point3D> Mackey
        {
            get { return SharpGLForm.mackey; }
        }
        private static List<Point3D> listCentroids = new List<Point3D>();
        private static Point3D ptTemp;
        private static int counter = 1;
        private static int temp = 0;
        private static int tau, numberOfPoints, power, centroid;
        private static double beta, gamma;
        private static Thread thread;
        private static FuzzyAdmin admin;
      
        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGLForm"/> class.
        /// </summary>
        public SharpGLForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            counter = counter % (mackey.Count - 1);
            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            //  Rotate around the Y axis.
            gl.Rotate(rotationX, rotationY, rotationZ);

            //  Draw a coloured pyramid.
            gl.Begin(OpenGL.GL_LINES);       
            if(CHK_MACKEY.Checked)
                for (int i = temp; i < mackey.Count - 1; i++)
                {
                    ptTemp = (Point3D)mackey[i].Tag;
                    gl.Color(ptTemp.X , ptTemp.Y , ptTemp.Z );
                    gl.Vertex(mackey[i].X, mackey[i].Y, mackey[i].Z);
                    gl.Vertex(mackey[i + 1].X, mackey[i + 1].Y, mackey[i + 1].Z);
                }
            gl.End();
            
            gl.Begin(OpenGL.GL_POINTS);
            if (CHK_MACKEY_DOTS.Checked)
                for (int i = temp; i < mackey.Count; i++)
                {
                    ptTemp = (Point3D)mackey[i].Tag;
                    gl.Color(ptTemp.X, ptTemp.Y, ptTemp.Z);
                    gl.Vertex(mackey[i].X, mackey[i].Y, mackey[i].Z);
                }

            if(CHK_CLUSTER.Checked)
                for (int j = 0; j < listCentroids.Count; j++) 
                {
                    ptTemp = (Point3D)listCentroids[j].Tag;
                    gl.Color(ptTemp.X, ptTemp.Y, ptTemp.Z);
                    gl.Vertex(listCentroids[j].X, listCentroids[j].Y, listCentroids[j].Z);


                }
            gl.End();

            //  Nudge the rotation.
            if (CHK_ROTATE_Y.Checked)
                rotationY += .25f;
            if (CHK_ROTATE_X.Checked)
                rotationX += .25f;
            if (CHK_ROTATE_Z.Checked)
                rotationZ += .25f;

            counter++;
            if (counter > mackey.Count / 5)
                temp = counter - mackey.Count / 5;
            else
                temp = counter = mackey.Count / 5;
        }


        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(.1f, 0.1f, 0.1f, 0);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.001, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(1, 1, 1, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
           
        }

        /// <summary>
        /// The current rotation.
        /// </summary>
        private float rotationY = 0.0f;
        private float rotationX = 0.0f;
        private float rotationZ = 0.0f;

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            string[] coordenates;
            Point3D tempPoint;

            System.IO.StreamReader file =
               new System.IO.StreamReader("Mackey-10066.txt");

            while ((line = file.ReadLine()) != null)
            {
                coordenates = line.Split(' ');
                tempPoint = new Point3D(Convert.ToDouble(coordenates[0]),
                    Convert.ToDouble(coordenates[1]), Convert.ToDouble(coordenates[2]));
                tempPoint.Tag = new Point3D((float)(Convert.ToDouble(coordenates[0])),
                    (float)(Convert.ToDouble(coordenates[1])), (float)(Convert.ToDouble(coordenates[2])));
                mackey.Add(tempPoint);
                
            }
            file.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(FillFuzzy);
            thread.Start();

        }

        private static void FillFuzzy()
        {
            admin = new FuzzyAdmin(mackey);

            ArrayList centroids = FuzzyAdmin.LoadCentroids(listCentroids);
            string line;
            string[] membership;
            int j = 0;
            double[,] matrixCMeans = new double[mackey.Count, listCentroids.Count];

            System.IO.StreamReader file =
              new System.IO.StreamReader("Fuzzy-10066.txt");

            while ((line = file.ReadLine()) != null)
            {
                membership = line.Split(' ');
                for (int k = 0; k < membership.Length; k++)
                {
                    matrixCMeans[j, k] = Convert.ToDouble(membership[k]);
                }
                j++;
            }
            file.Close();
            FuzzyAdmin.ComputeColors(centroids, matrixCMeans);
        }

        private void Clusterize()
        {
            KMeans k = new KMeans(mackey);
            centroid = int.Parse(TXT_CLUSTERS.Text);
            listCentroids = k.Execute(centroid);
            GC.Collect();

            Fuzzify();
        }

        private static void Fuzzify()
        {
            admin = new FuzzyAdmin(mackey);
            admin.Execute(listCentroids);
            GC.Collect();
        }

        private void SharpGLForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread != null)
            if (thread.IsAlive)
                thread.Abort();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            string[] lines = new string[listCentroids.Count];
            for (int i = 0; i < lines.Length; i++)
                lines[i] = listCentroids[i].ToString();

            System.IO.File.WriteAllLines(@"-"+lines.Length+".txt", lines);
            Fuzzify();
        }

        private void BTN_LOAD_Click(object sender, EventArgs e)
        {
            thread = new Thread(LoadClusters);
            thread.Start();
        }

        private void LoadClusters()
        {
            string[] lines = System.IO.File.ReadAllLines(@"-50.txt");
            Random random = new Random();
            listCentroids = new List<Point3D>();
            string[] line;
            Point3D pt;
            for (int l = 0; l < lines.Length; l++)
            {
                line = lines[l].Split(' ');
                pt = new Point3D(double.Parse(line[0]), double.Parse(line[1]), double.Parse(line[2]));
                pt.Tag = new Point3D(random.NextDouble(), random.NextDouble(), random.NextDouble());
                listCentroids.Add(pt);
            }
            MyDelegates.SetTextValue(TXT_CLUSTERS, listCentroids.Count.ToString());
            
            //Fuzzify();
        }

        private void BTN_POINTS_Click(object sender, EventArgs e)
        {
            string[] lines = new string[mackey.Count];
            for (int i = 0; i < lines.Length; i++)
                lines[i] = mackey[i].ToString();

            System.IO.File.WriteAllLines(@"Mackey-" + lines.Length + ".txt", lines);
        }

        private void BTN_FUZZY_Click(object sender, EventArgs e)
        {
            FuzzyAdmin.SaveFuzzy();
        }

    }
}