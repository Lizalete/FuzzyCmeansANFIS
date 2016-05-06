using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neural;
using System.Diagnostics;

namespace Test
{
    public partial class Form1 : Form
    {
        NeuralNetwork nn;
        List<Input> listInputs;
        List<double[]> listMackey;
        List<double[]> listMu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listInputs = new List<Input>();
            listMackey = new List<double[]>();
            listMu = new List<double[]>();
            LoadMackey();
            LoadFuzzy();
            LoadInputs();
             Input inp = listInputs[0];
             nn = new NeuralNetwork(25, 1, .95, inp);
             Debug.WriteLine("YA COMPILO!");
        }

        void LoadMackey() {
            double maxX = 0;
            double maxY = 0;
            double maxZ = 0;
            double minX = 0;
            double minY = 0;
            double minZ = 0;
            int minimo = 0;
            int maximo = 1;
            double x = 0;
            double y = 0;
            double z = 0;
            string line;
            string[] coordenates;
            double[] featurePoints;

            System.IO.StreamReader file =
               new System.IO.StreamReader("Mackey-10066.txt");

            while ((line = file.ReadLine()) != null)
            {
                coordenates = line.Split(' ');
                x = Convert.ToDouble(coordenates[0]);
                y =  Convert.ToDouble(coordenates[1]);
                z = Convert.ToDouble(coordenates[2]);
                featurePoints = new double[] {x, y, z};
                listMackey.Add(featurePoints);
                if (x > maxX){ maxX = x; }
                else {
                    if (x < minX) { minX = x; }
                }

                if (y > maxY) { maxY = y; }
                else
                {
                    if (y < minY) { minY = y; }
                }

                if (z > maxZ) { maxZ = z; }
                else
                {
                    if (z < minZ) { minZ = z; }
                }

            }
            NormalizeList(minimo, maximo, maxX, maxY, maxZ, minX, minY, minZ);
            file.Close();  
        
        }

        void LoadFuzzy() {
            string line;
            string[] membership;
            double[] desired;
           
            System.IO.StreamReader file =
              new System.IO.StreamReader("Fuzzy-10066.txt");

            while ((line = file.ReadLine()) != null)
            {
                membership = line.Split(' ');
                desired = new double[membership.Length];
                for (int k = 0; k < membership.Length; k++)
                {
                    desired[k] = Convert.ToDouble(membership[k]);
                }
                listMu.Add(desired);
            }
            file.Close();
        }

        void LoadInputs() {
            Input inp;
            if (listMackey.Count == listMu.Count) {
                for (int i = 0; i < listMackey.Count; i++) {
                    //inp = new Input(listMackey[i], listMu[i]);
                    inp = new Input(listMu[i], listMackey[i]);
                    listInputs.Add(inp);
                }
            }
        }

        void NormalizeList(int a, int b, double maxX, double maxY, double maxZ, double minX, double minY, double minZ) {
            double [] temp, newMackey;
            double newX = 0;
            double newY = 0;
            double newZ = 0;
            for (int i = 0; i < listMackey.Count; i++) {
                temp = listMackey[i];
                newX = (((b - a) * (temp[0] - minX)) / (maxX - minX)) + a;
                newY = (((b - a) * (temp[1] - minY)) / (maxY - minY)) + a;
                newZ = (((b - a) * (temp[2] - minZ)) / (maxZ - minZ)) + a;
                newMackey = new double[]{newX,newY,newZ};
                listMackey.RemoveAt(i);
                listMackey.Insert(i, newMackey);
            }
        
        
        }
        private void BTN_TRAIN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                label1.Text = nn.SetPatternsRandom(listInputs.ToArray()).ToString();
            }    
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            nn.SaveNetwork("NeuralMackey.txt");
        }
    }
}