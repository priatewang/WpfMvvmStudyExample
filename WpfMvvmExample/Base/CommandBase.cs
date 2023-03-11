using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmExample.Base
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> _action;
        private bool _isEnableExecute = true;

        public bool IsEnableExecute
        {
            get
            {
                return _isEnableExecute;
            }

            set
            {
                if (_isEnableExecute != value)
                {
                    _isEnableExecute = value;
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, new EventArgs());
                    }
                }

            }
        }
        public CommandBase(Action<object> action)
        {
            if (action == null)
            {
                return;

            }
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return _isEnableExecute;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
