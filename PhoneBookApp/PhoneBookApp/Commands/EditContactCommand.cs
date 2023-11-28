using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookApp.Commands
{
    public class EditContactCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<Contact> _Execute;

        public EditContactCommand(Action<Contact> execute)
        {
            _Execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _Execute.Invoke(parameter as Contact);
        }
    }
}
