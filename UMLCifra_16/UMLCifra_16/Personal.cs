namespace UMLCifra_16
{
    public abstract class Personal
    {
        protected Mediator _mediator;

        public Personal(Mediator mediator)
        {
            _mediator = mediator;
        }
        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}
