using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookApp.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _Execute;
        private Predicate<object> _Predicate;

        public RelayCommand(Action<object> execute, Predicate<object> predicate)
        {
            _Execute = execute;
            _Predicate = predicate;
        }

        public RelayCommand(Action<object> execute)
        {
            _Execute = execute;
            _Predicate = null;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _Predicate == null ? true : _Predicate(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute.Invoke(parameter);
        }
    }
}
