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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_UIdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Storyboard myStoryboard = null;
        public MainWindow()
        {
            InitializeComponent();

            //DrawRectAnimation();
        }

        void DrawRectAnimation()
        {
            StackPanel myPanel = new StackPanel();
            myPanel.Margin = new Thickness(10);

            Rectangle myRectangle = new Rectangle();
            myRectangle.Name = "myRectangle";
            this.RegisterName(myRectangle.Name, myRectangle);
            myRectangle.Width = 100;
            myRectangle.Height = 100;
            myRectangle.Fill = Brushes.Blue;

            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 1.0;
            myDoubleAnimation.To = 0.0;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(5));
            myDoubleAnimation.AutoReverse = true;
            myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, myRectangle.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Rectangle.OpacityProperty));

            myRectangle.Loaded += MyRectangle_Loaded;
            myPanel.Children.Add(myRectangle);
            this.Content = myPanel;
        }
        private void MyRectangle_Loaded(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin(this);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B2_Completed(object sender, EventArgs e)
        {
            //Storyboard translationAnimationStoryboard = (Storyboard)this.Resources["TranslationAnimationStoryboardResource"];
            //translationAnimationStoryboard.Begin(this);
        }

        private void BtnCommon_Click(object sender, RoutedEventArgs e)
        {
            GlyphRun theGlyphGun = new GlyphRun(
                new GlyphTypeface(new Uri(@"C:\windows\Fonts\TIMES.TTF")),
                0,
                false,
                13.3333333333334,
                new ushort[] { 43, 72, 79, 79, 82, 3, 58, 82, 85, 79, 71 },
                new Point(0, 12.29),
                new double[] {
                9.62666666666667, 7.41333333333333, 2.96,
                2.96, 7.41333333333333, 3.70666666666667,
                12.5866666666667, 7.41333333333333,
                4.44, 2.96, 7.41333333333333},
                null,
                null,
                null,
                null,
                null,
                null);

            GlyphRunDrawing gDrawing = new GlyphRunDrawing(Brushes.Black, theGlyphGun);
        }
    }
}
