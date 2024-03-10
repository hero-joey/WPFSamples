using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlDataGridSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeComponent();
            ObservableCollection<Customer> customers = GetData();
            CustomerDataGrid.DataContext = customers;
        }

        private ObservableCollection<Customer> GetData()
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            customers.Add(new Customer() { FirstName = "Orlando", LastName = "Gee", Email = new Uri("mailto:max@provider.com"), IsMember = true, Status = new OrderStatus() });
            customers.Add(new Customer() { FirstName = "Orlando", LastName = "Gee", Email = new Uri("mailto:max@provider.com"), IsMember = false, Status = new OrderStatus() });
            customers.Add(new Customer() { FirstName = "Orlando", LastName = "Gee", Email = new Uri("mailto:max@provider.com"), IsMember = false, Status = new OrderStatus() });
            customers.Add(new Customer() { FirstName = "Orlando", LastName = "Gee", Email = new Uri("mailto:max@provider.com"), IsMember = false, Status = new OrderStatus() });
            return customers;
        }
    }
}