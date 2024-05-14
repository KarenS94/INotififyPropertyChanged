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

namespace INotififyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Suma ObjetoSuma { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ObjetoSuma = new Suma { Num1= "1", Num2 = "2"};
            this.DataContext = ObjetoSuma;
        }
    }
}