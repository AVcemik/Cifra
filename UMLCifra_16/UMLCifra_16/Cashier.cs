﻿namespace UMLCifra_16
{
    public class Cashier: Personal
    {
        public Cashier(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("Сообщение кассиру: " + msg);
        }
    }
}
