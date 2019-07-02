using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Task2.Command;
using System_Task2.View;

namespace System_Task2.ViewModel
{
  public  class MainViewModel:BaseViewModel
    {
        public ConfigurationCommand configurationCommand { get; set; }
        public LogCommand logCommand { get; set; }
        public ProcessCommand processCommand { get; set; }
        public MainViewModel(Windows windows)
        {
            processCommand = new ProcessCommand(windows);
            logCommand = new LogCommand(windows);
            configurationCommand = new ConfigurationCommand(windows);
            Process process = new Process(windows);
            windows.Grid.Children.Add(process);
        }

    }
}
