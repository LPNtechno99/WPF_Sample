using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace WPF_UIdemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Canvas canvasObj = new Canvas();
        public Window1()
        {
            InitializeComponent();
            InitChart();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {

        }
        private void InitChart()
        {

            this.Content = canvasObj;

            Line(10.0, 150.0, 200.0, 150.0, Colors.DarkBlue);

            Text(210.0, 150.0, "It works", Colors.Red);

        }



        private void Line(double x1, double y1, double x2, double y2,

                          Color color)
        {

            Line lineObj = new Line();

            lineObj.Stroke = new SolidColorBrush(color);

            lineObj.X1 = x1;

            lineObj.X2 = x2;

            lineObj.Y1 = y1;

            lineObj.Y2 = y2;

            canvasObj.Children.Add(lineObj);

        }



        private void Text(double x, double y, string text,

                          Color color)
        {

            TextBlock textBlock = new TextBlock();

            textBlock.Text = text;

            textBlock.Foreground = new SolidColorBrush(color);

            Canvas.SetLeft(textBlock, x);

            Canvas.SetTop(textBlock, y);

            canvasObj.Children.Add(textBlock);

            // The following does't work because "dc" is not a UIElement

            // canvasObj.Children.Add(dc);

        }
    }

}
