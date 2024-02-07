using HomeCifraWPF___88.Context;
using System.ComponentModel;
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
            AddDataBT.IsEnabled = false;
            using (var context = new ApplicationContext())
            {
                Data MyData = new Data(context.Peopls.FirstOrDefault()!);
                DataStack.DataContext = MyData;

                MessageBox.Show("Данные заруженны");
            }
            AddDataBT.IsEnabled = true;
        }
    }

    public class Data : INotifyPropertyChanged
    {
        private string? _firstName;
        private string? _lastName;
        private string? _age;
        public string FirstName
        {
            get 
            {
                return _firstName!;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        public string LastName
        {
            get 
            {
                return _lastName!;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public string Age
        {
            get 
            {
                return _age!;
            }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public Data(People people)
        {
            FirstName = people.FirstName!;
            LastName = people.LastName!;
            Age = people.Age.ToString();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }


}