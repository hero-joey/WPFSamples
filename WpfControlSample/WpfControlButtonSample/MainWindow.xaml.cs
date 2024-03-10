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

namespace WpfControlButtonSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _clickCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBtn1Click(object sender, RoutedEventArgs e)
        {
            Btn2.Background = new SolidColorBrush(Colors.Red);
            Btn2.Width = 200;
            Btn2.Content = "Btn2 Changed";
        }

        private void RadioButton1Checked(object sender, RoutedEventArgs e)
        {
            RadioButton? currentRadioButton = sender as RadioButton;
            if (currentRadioButton != null)
            {
                RadioChoice.Text = currentRadioButton.Content.ToString();
            }
        }

        private void OnRepeatButtonClicked(object sender, RoutedEventArgs e)
        {
            _clickCount++;
            RepeatButtonInfo.Text = $"RepeatButton clicked {_clickCount} times";
        }
    }
}