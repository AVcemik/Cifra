namespace UMLCifra_16
{
    public abstract class Personal
    {
        protected Mediator _mediator;

        public Personal(Mediator mediator)
        {
            _mediator = mediator;
        }
        public virtual void Send(string msg)
        {
            _mediator.Send(msg, this);
        }
        public abstract void Notify(string msg);
    }
}
