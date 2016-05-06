using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyC_Means
{
    public class ClusterCentroid : ClusterPoint
    {
        /// Basic constructor
        ///
        /// Centroid x-coord
        /// Centroid y-coord
        public ClusterCentroid(double x, double y,double z): base(x, y, z)
        {
        }
    }
}
