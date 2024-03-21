﻿namespace UMLCifra_16
{
    public class Cook: Personal
    {
        public Cook(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("Сообщение повару: " + msg);
        }
    }
}
