﻿using System;
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

namespace CreateShapesDynamically
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum SelectedShape
        {
            None,
            Circle,
            Rectangle
        }
        private SelectedShape Shape1 = SelectedShape.None;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void CreateShape1_Click(object sender, RoutedEventArgs e)
        {
            Shape1 = SelectedShape.Rectangle;
        }

        private void CreateShape2_Click(object sender, RoutedEventArgs e)
        {
            Shape1 = SelectedShape.Circle;
        }

        private void CanvasArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape Rendershape = null;
            switch (Shape1)
            {
                case SelectedShape.Circle:
                    Rendershape = new Ellipse() { Height = 40, Width = 40 };
                    RadialGradientBrush brush = new RadialGradientBrush();
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF7689"), 0.250));
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF7689"), 0.100));
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF7689"), 8));

                    Rendershape.Fill = brush;
                    break;
                case SelectedShape.Rectangle:
                    Rendershape = new Rectangle() { Fill = Brushes.Blue, Height = 45, Width = 45, RadiusX = 12, RadiusY = 12 };
                    break;
                default:
                    break;
            }
            Canvas.SetLeft(Rendershape, e.GetPosition(canvasArea).X);
            Canvas.SetTop(Rendershape, e.GetPosition(canvasArea).Y);

            canvasArea.Children.Add(Rendershape);
        }

        private void CanvasArea_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition((Canvas)sender);
            HitTestResult result = VisualTreeHelper.HitTest(canvasArea, pt);

            if(result!=null)
            {
                canvasArea.Children.Remove(result.VisualHit as Shape);
            }
        }
    }
}
