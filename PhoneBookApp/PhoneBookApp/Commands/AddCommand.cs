using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookApp.Commands
{
    public class AddCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<Contact> _Execute;

        public AddCommand(Action<Contact> exectue)
        {
            _Execute = exectue;
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
