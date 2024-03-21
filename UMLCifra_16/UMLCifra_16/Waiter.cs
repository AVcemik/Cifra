namespace UMLCifra_16
{
    public class Waiter : Personal
    {
        public Waiter(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение официанту: " + message);
        }
    }
}
