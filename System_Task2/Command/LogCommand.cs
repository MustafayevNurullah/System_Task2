using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System_Task2.View;

namespace System_Task2.Command
{
    public class LogCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Windows Windows;
        public LogCommand ( Windows windows)
        {
            Windows = windows;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LogView logView = new LogView();
            Windows.Grid.Children.Add(logView);
        }
    }
}
