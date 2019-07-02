using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System_Task2.Command;
using System_Task2.Entity;
using System_Task2.View;

namespace System_Task2.ViewModel
{
    public class ProecessVIewModel : BaseViewModel
    {
            ConfigurationViewModel a = new ConfigurationViewModel();
        public ProecessVIewModel(Windows windows )
        {
             ProcessList = new ObservableCollection<ProcessEntity>();
            asdasd();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(50);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        public void asdasd()
        {
            
            var result = System.Diagnostics.Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0).ToList();
            
                foreach (var item in result)
                {

                foreach ( var item1 in a.process) 
                {
                    if(item1==item.MainWindowTitle)
                    {
                        item.Kill();
                    }
                }      
              
                    ProcessEntity entity = new ProcessEntity()
                    {
                        Datetime = item.StartTime,
                        Id = item.Id,
                        Title = item.MainWindowTitle,
                        Name = item.ProcessName

                    };
                    ProcessList.Add(entity);
                }
          
            
            string json = JsonConvert.SerializeObject(ProcessList);
               System.IO.File.WriteAllText("Process.json", json);
           
           
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            ProcessList.Clear();
            try
            {

            asdasd();
            }
            catch (Exception)
            {

             
            }
        }

        private ObservableCollection<ProcessEntity> processList;
        public ObservableCollection<ProcessEntity> ProcessList
        {

            get => processList;
            set
            {
                processList = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ProcessList)));
            }

        }

    }
}
