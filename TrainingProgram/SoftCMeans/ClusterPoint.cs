using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyC_Means
{
    public class ClusterPoint
    {
        /// Gets or sets Z-coord of the point
        ///
        public double X { get; set; }

        /// Gets or sets X-coord of the point
        ///
        public double Y { get; set; }

        ///
        /// Gets or sets Y-coord of the point
        ///

        public double Z { get; set; }

        ///
        /// Gets or sets some additional data for point
        ///
        public object Tag { get; set; }

        ///
        /// Gets or sets cluster index
        ///
        public double ClusterIndex { get; set; }
        ///
        /// Basic constructor
        ///

        /// X-coord
        /// Y-coord
        public ClusterPoint(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            ClusterIndex = -1;
        }
        
        ///
        /// Basic constructor
        ///
        /// X-coord
        /// Y-coord
        public ClusterPoint(double x, double y,double z, object tag)
        {
            X = x;
            Y = y;
            Z = z;

            Tag = tag;
            ClusterIndex = -1;
        }

        public override string ToString()
        {
            string str;

            str = X + " " + Y + " " + Z;
            return str;
        }
    }
}
