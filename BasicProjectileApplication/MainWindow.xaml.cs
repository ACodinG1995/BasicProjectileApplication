using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicProjectileApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  public TextBox TimeOutputBox;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double speed = Double.Parse(SpeedInputBox.Text);
            double angle = Double.Parse(AngleInputBox.Text);

            if (UseDegreesCheckbox.IsChecked == true) { 
                angle = AngleCalculations.convertDegreesToRadians(angle);
            }

            double verticalSpeed = ProjectileCalculations.caclulateVerticalSpeed(speed, angle);

            double timeInAir = ProjectileCalculations.calculateTimeInAir(verticalSpeed);
            TimeOutputBox.Text = timeInAir.ToString("#.##");

            double heightReached = ProjectileCalculations.calculateHeightReached(verticalSpeed, timeInAir);
            HeightOutputBox.Text = heightReached.ToString("#.##");

            double horizontalSpeed = ProjectileCalculations.caclulateHorizontalSpeed(speed, angle);
            double distanceTravelled = ProjectileCalculations.calculateDistanceTravelled(horizontalSpeed, timeInAir);
            DistanceOutputBox.Text = distanceTravelled.ToString("#.##");
        }
    }
}
