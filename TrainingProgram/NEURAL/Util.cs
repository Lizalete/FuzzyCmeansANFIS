using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    public class Util
    {
        public const int MAX_CANVAS_WIDTH = 750;
        public const int MAX_CANVAS_HEIGHT = 650;

        public const int CENTER_WIDHT = 375;
        public const int CENTER_HEIGHT = 325;

        public const short ZERO = short.MinValue;

        public static double SigmoidDerivative(double x)
        {
            return x * (1 - x);
        }
    }
}
