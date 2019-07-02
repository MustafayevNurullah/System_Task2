using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System_Task2.View;

namespace System_Task2.Command
{
    public class ProcessCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Windows Windows;
        public ProcessCommand (Windows windows)
        {
            Windows = windows;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Process process = new Process(Windows);
            Windows.Grid.Children.Add(process);
        }
    }
}
