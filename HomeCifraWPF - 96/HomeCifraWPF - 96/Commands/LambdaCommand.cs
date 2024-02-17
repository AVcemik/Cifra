using HomeCifraWPF___96.Commands.BaseCommands;

namespace HomeCifraWPF___96.Commands
{
    public class LambdaCommand : Command
    {
        private Action<Object>? _execute;
        private Func<Object, bool>? _canExucute;

        public LambdaCommand(Action<object> execute, Func<object, bool> canExucute)
        {
            _execute = execute;
            _canExucute = canExucute;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            _execute!(parameter!);
        }
    }
}
