using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectileApplication

{
    internal class ProjectileCalculations
    {
        private const double g = 9.81;

        public static double caclulateVerticalSpeed(double speed, double angle) { 
            return speed * Math.Cos(angle);
        }

        public static double caclulateHorizontalSpeed(double speed, double angle){
            return speed * Math.Sin(angle);
        }

        public static double calculateTimeInAir(double vertialSpeed) {
            return vertialSpeed / 9.81;
        }

        public static double calculateDistanceTravelled(double horizontalSpeed, double timeInAir) {
            return horizontalSpeed * timeInAir;
        }

        public static double calculateHeightReached(double verticalSpeed, double timeInAir) {
            return verticalSpeed * timeInAir - 0.5 * g * timeInAir * timeInAir;
        }









    }




}
