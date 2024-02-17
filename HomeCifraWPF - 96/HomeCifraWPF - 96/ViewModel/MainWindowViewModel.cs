using HomeCifraWPF___96.Commands;
using HomeCifraWPF___96.Models;
using HomeCifraWPF___96.Services;
using HomeCifraWPF___96.ViewModel.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace HomeCifraWPF___96.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Product>? _products;

        public ObservableCollection<Product> Products
        {
            get
            {
                return _products ?? throw new Exception("Лист продуктов пуст (Null)");
            }
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        public ICommand SaveDataCSVFileCommand { get; }
        public ICommand ExitApplicationCommand { get; }

        public MainWindowViewModel()
        {
            Products = ProductListCreator.GetProducts();
            SaveDataCSVFileCommand = new LambdaCommand(OnSaveDataCSVFileCommand, (object obj) => true);
            ExitApplicationCommand = new LambdaCommand(OnExitApplicationCommand, (object obj) => true);
        }
        private void OnSaveDataCSVFileCommand(object obj)
        {
            List<Product> products = new();
            foreach (var item in _products!)
            {
                products.Add(item);
            }
            CSVOperation.SaveCSVFile(products);
            MessageBox.Show("Файл успешно сохранен");
        }
        private void OnExitApplicationCommand(object obj)
        {
            Application.Current.Shutdown();
        }
    }
}
