
namespace Titanic
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public int Survived { get; set; }
        public int Pclass { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? Age { get; set; }
        public int SibSp { get; set; }
        public string? Parch { get; set; }
        public string? Ticket { get; set; }
        public double Fare { get; set; }
        public string? Cabin { get; set; }
        public string? Embarked { get; set; }
    }
}
