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

namespace CanvasSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            Ellipse elp = new Ellipse() { Height = 50, Width = 50 };
            RadialGradientBrush brush = new RadialGradientBrush();
            brush.GradientStops.Add(new GradientStop((Colors.AliceBlue), 0));
            brush.GradientStops.Add(new GradientStop((Colors.LightBlue), 1));
            brush.GradientStops.Add(new GradientStop((Colors.DarkBlue), 2));

            elp.StrokeThickness = 2;
            elp.Stroke = Brushes.Black;

            elp.Fill = brush;
            Canvas.SetLeft(elp,50);
            Canvas.SetTop(elp,50);
            CanvasPanel.Children.Add(elp);
        }
        
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            if (btnShow.IsChecked == true)
            {
                btnShow.Content = "Hidden";
                TwoDEllipse.Visibility = Visibility.Visible;
                TwoDRectangle.Visibility = Visibility.Visible;
                TwoDRectangle2.Visibility = Visibility.Visible;
                TwoDPath.Visibility = Visibility.Visible;
                PathHeart.Visibility = Visibility.Visible;
            }
            else
            {
                btnShow.Content = "Visibility";
                TwoDEllipse.Visibility = Visibility.Hidden;
                TwoDRectangle.Visibility = Visibility.Hidden;
                TwoDRectangle2.Visibility = Visibility.Hidden;
                TwoDPath.Visibility = Visibility.Hidden;
                PathHeart.Visibility = Visibility.Hidden;
            }
        }
    }
}
