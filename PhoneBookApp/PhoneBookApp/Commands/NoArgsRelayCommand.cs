using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookApp.Commands
{
    public class NoArgsRelayCommand : ICommand
    {
        private Action _Execute;

        public NoArgsRelayCommand(Action execute)
        {
            _Execute = execute;
        }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _Execute.Invoke();
        }
    }
}
