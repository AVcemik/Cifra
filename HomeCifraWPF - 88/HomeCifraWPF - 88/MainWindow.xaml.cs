using HomeCifraWPF___88.Context;
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

namespace HomeCifraWPF___88
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

        private void AddDataBT_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicationContext())
            {
                People people = context.Peopls.First();

                FirstNameTB.Text = people.FirstName;
                LastNameTB.Text = people.LastName;
                AgeTB.Text = people.Age.ToString();
            }
        }
    }
}