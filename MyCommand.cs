using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EnlaceDeDatos
{
    public class MyCommand : ICommand
    {
        Action action;
        Func<bool> canExecute;
        public MyCommand(Action action) : this(action, () => true)
        {
           // this.action = action;
        }
        public event EventHandler CanExecuteChanged;

        public void ReevaluateCanExecute()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        public MyCommand(Action action, Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
