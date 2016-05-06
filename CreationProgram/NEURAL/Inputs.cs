using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    public class Input
    {
        #region Properties
        List<double> features = new List<double>();

        public List<double> FeaturesList
        {
            get { return features; }
            set { features = value; }
        }
        double[] desiredValue;
        string desire;
        #endregion 
    
        public Input(double[] features, double[] desiredValue,string desire)
        {
            //this.features = features;
            this.features.AddRange(features);
            this.desiredValue = desiredValue;
            this.desire = desire;
        }

        public Input(double[] features, double[] desiredValue)
        {
            //this.features = features;
            this.features.AddRange(features);
            this.desiredValue = desiredValue;
        }

        #region Fields
        public int Size
        {
            get { return features.Count; }
        }

        public double[] Features
        {
            get { return features.ToArray(); }
            set { this.features.AddRange(value); }
        }

        public double[] DesiredValue
        {
            get { return desiredValue; }
        }

        public string Desire
        {
            get { return desire; }
        }
        #endregion

    }
}
