using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System_Task2.View;

namespace System_Task2.Command
{
    public class ConfigurationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Windows Windows;
        public ConfigurationCommand(Windows windows)
        {
            this.Windows = windows;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Windows.Grid.Children.Clear();
            ConfigurationView configurationView = new ConfigurationView();
            Windows.Grid.Children.Add(configurationView);
        }
    }
}
