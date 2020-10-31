using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WPFTookit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread _pilotchart;
        ObservableCollection<KeyValuePair<string, int>> _MyValue1;
        DispatcherTimer timer;
        Random rand = new Random();
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            ShowColumnChart();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (count > 10)
            {
                _MyValue1.Clear();
                count = 0;
            }
            int a = rand.Next(10);
            _MyValue1.Add(new KeyValuePair<string, int>(DateTime.Now.ToString("hh:mm:ss"), a));
            Line1.DataContext = _MyValue1;
            count++;
        }

        private void ShowColumnChart()
        {
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            MyValue.Add(new KeyValuePair<string, int>("Mahak", 300));
            MyValue.Add(new KeyValuePair<string, int>("Pihu", 250));
            MyValue.Add(new KeyValuePair<string, int>("Rahul", 289));
            MyValue.Add(new KeyValuePair<string, int>("Raj", 256));
            MyValue.Add(new KeyValuePair<string, int>("Vikas", 140));

            _MyValue1 = new ObservableCollection<KeyValuePair<string, int>>();

            ColumnChart1.DataContext = MyValue;
            AreaChart1.DataContext = MyValue;

            PieChart1.DataContext = MyValue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        void PilotChart()
        {
            Line1.Dispatcher.Invoke(new Action(() =>
            {
                Line1.DataContext = _MyValue1;
            }));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
