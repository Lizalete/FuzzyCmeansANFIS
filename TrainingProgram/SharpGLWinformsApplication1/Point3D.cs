using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGLWinformsApplication1
{
    public class Point3D
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

        public int Counter { get; set; }

        public bool IsMedian { get; set; }

        internal List<Point3D> Points {get; set;}

        ///
        /// Gets or sets some additional data for point
        ///
        public object Tag { get; set; }

        ///
        /// Gets or sets cluster index
        ///
        public int ClusterIndex { get; set; }

        ///
        /// Basic constructor
        ///
        /// X-coord
        /// Y-coord
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            ClusterIndex = -1;
            Points = new List<Point3D>();
        }
        
        ///
        /// Basic constructor
        ///
        /// X-coord
        /// Y-coord
        public Point3D(double x, double y, double z, object tag)
        {
            X = x;
            Y = y;
            Z = z;
            Tag = tag;
            ClusterIndex = -1;
            Points = new List<Point3D>();
        }

        public override string ToString()
        {
            string str;

            str = X+" "+Y+" "+Z;
            return str;
        }
    }
}
