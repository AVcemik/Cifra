using OfflineShop.Models;
using OfflineShop.Services;
using OfflineShop.ViewModel.Base;
using System.Collections.ObjectModel;

namespace OfflineShop.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Product>? _products;

        public ObservableCollection<Product> Products
        {
            get { return _products!; }
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }

            }
        }

        public MainWindowViewModel()
        {
            Products = CsvFileReader.GetCsvFile();
        }
    }
}
