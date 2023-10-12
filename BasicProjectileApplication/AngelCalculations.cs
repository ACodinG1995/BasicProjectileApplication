using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectileApplication
{
    internal class AngleCalculations
    {
        public static double convertDegreesToRadians(double degrees) {
            return degrees * Math.PI / 180;
        }

        public static double convertRadiansToDegrees(double radians) {
            return radians * 180 / Math.PI;
        }    

    }
}
