using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.UserControls
{
    public class ViewModelCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecuteAction;
        private ICommand? showHomeView;

        public ViewModelCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecuteAction = null;
        }

        public ViewModelCommand(ICommand? showHomeView)
        {
            this.showHomeView = showHomeView;
        }

        public ViewModelCommand(Action<object> execute, Predicate<object> canExecuteAction)
        {
            _execute = execute;
            _canExecuteAction = canExecuteAction;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove {  CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
