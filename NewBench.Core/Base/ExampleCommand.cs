using System.Windows.Input;

namespace NewBench.Core.Base
{
    public class ExampleCommand : ICommand
    {
        private readonly Action? _action;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action?.Invoke();
        }
        public ExampleCommand(Action? action)
        {
            _action = action;
        }
    }
}
