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

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //public static readonly RoutedEvent ConnectButtonClickEvent = EventManager.RegisterRoutedEvent(
        //   "ConnectButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl1));

        //public event RoutedEventHandler ConnectButtonClick
        //{
        //    add { AddHandler(ConnectButtonClickEvent, value); }
        //    remove { RemoveHandler(ConnectButtonClickEvent, value); }
        //}

        public static readonly RoutedEvent ConnectButtonClickEvent = EventManager.RegisterRoutedEvent(
            "ConnectButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl1));

        public event RoutedEventHandler ConnectButtonClick
        {
            add { AddHandler(ConnectButtonClickEvent, value); }
            remove { RemoveHandler(ConnectButtonClickEvent, value); }
        }
        public void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ConnectButtonClickEvent));
        }
    }
}
