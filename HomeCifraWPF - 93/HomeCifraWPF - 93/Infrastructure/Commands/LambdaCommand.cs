using HomeCifraWPF___93.Infrastructure.Commands.CommandBase;

namespace HomeCifraWPF___93.Infrastructure.Commands
{
    public class LambdaCommand : Command
    {
        private Action<Object> _execute;
        private Func<Object, bool> _canExecute;

        public LambdaCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            _execute(parameter!);
        }
    }
}
