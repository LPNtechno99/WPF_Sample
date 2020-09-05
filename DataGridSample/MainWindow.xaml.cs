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

namespace DataGridSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MCDataGrid.ItemsSource = LoadCollectionData();
            dataGrid2.ItemsSource = LoadCollectionData();
            dataGrid3.ItemsSource = LoadCollectionData();
        }
        private List<Author> LoadCollectionData()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Mahesh Chand",
                BookTitle = "Graphics Programming with GDI+",
                DOB = new DateTime(1975, 2, 23),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 102,
                Name = "Marine",
                BookTitle = "Kids Baby",
                DOB = new DateTime(2020, 5, 08),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 103,
                Name = "Nam Catile",
                BookTitle = "Developer Scada",
                DOB = new DateTime(1993, 8, 19),
                IsMVP = false
            });
            return authors;
        }
        public class Author
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string BookTitle { get; set; }
            public bool IsMVP { get; set; }
        }
    }
}
