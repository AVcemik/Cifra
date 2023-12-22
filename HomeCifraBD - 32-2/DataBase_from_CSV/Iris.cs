using CsvHelper.Configuration.Attributes;

namespace DataBase_from_CSV
{
    public class Iris
    {
        [Ignore]
        public int Id { get; set; }
        [Name("sepal.length")]
        public double SepalLength { get; set; }
        [Name("sepal.width")]
        public double SepalWidth { get; set; }
        [Name("petal.length")]
        public double PetalLength { get; set; }
        [Name("petal.width")]
        public double PetalWidth { get; set; }
        [Name("variety")]
        public string? Variety { get; set; }

        public Iris()
        {
        }

        public Iris(double sepalLength, double sepalWidth, double petalLength, double petalWidth, string? variety)
        {

            SepalLength = sepalLength;
            SepalWidth = sepalWidth;
            PetalLength = petalLength;
            PetalWidth = petalWidth;
            Variety = variety;
        }

        public static int GetCountPropherties()
        {
            return 5;
        }
    }
}
