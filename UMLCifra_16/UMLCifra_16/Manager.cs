namespace UMLCifra_16
{
    public class Manager: Mediator
    {
        public Personal? Waiter { get; set; }
        public Personal? Cook { get; set; }
        public Personal? Cashier { get; set; }
        public override void Send(string msg, Personal personal)
        {

            if (Waiter == personal)
                Cook!.Notify(msg);
            else if (Cook == personal)
                Cashier!.Notify(msg);
            else if (Cashier == personal)
                Waiter!.Notify(msg);
        }
    }
}
