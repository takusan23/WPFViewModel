using System;
using System.Windows.Input;

namespace WPFViewModel
{
    class ViewModelButtonClick : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _click;

        public ViewModelButtonClick(Action click)
        {
            _click = click;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _click();
        }
    }
}
