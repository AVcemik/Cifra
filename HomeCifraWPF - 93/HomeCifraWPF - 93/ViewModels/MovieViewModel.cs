using HomeCifraWPF___93.Models;
using System.Collections.ObjectModel;
using HomeCifraWPF___93.ViewModels.Base;
using System.Windows.Input;
using HomeCifraWPF___93.Service;
using HomeCifraWPF___93.Infrastructure.Commands;

namespace HomeCifraWPF___93.ViewModels
{
    public class MovieViewModel : ViewModelBase
    {
        private ObservableCollection<Movie>? _movies;
        private Movie? _movie;
        public ObservableCollection<Movie> Movies
        {
            get => _movies ?? new ObservableCollection<Movie>() { new Movie() };
            set
            {
                if (_movies != value)
                {
                    _movies = value;
                    OnPropertyChanged(nameof(Movies));
                }
            }
        }
        public Movie Movie
        {
            get => _movie ?? new Movie();
            set
            {
                if (_movie != value)
                {
                    _movie = value;
                    OnPropertyChanged(nameof(Movie));
                }
            }
        }
        
        public ICommand LoadDataCommand { get; }

        public MovieViewModel()
        {
            _movies = new ObservableCollection<Movie>();
            _movie = new Movie();
            LoadDataCommand = new LambdaCommand(OnLoadDataExecute, (object obj) => true);
        }

        public void OnLoadDataExecute(object obj)
        {
            Movies.Clear();
            List<Movie> movies = SCVFileReader.ReadFile();

            foreach (var item in movies)
            {
                _movies!.Add(item);
            }
        }
    }
}
