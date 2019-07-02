using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System_Task2.Entity;

namespace System_Task2.ViewModel
{
    public class ProecessVIewModel : BaseViewModel
    {
        public ProecessVIewModel()
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

            var result = Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0).ToList();
            
                foreach (var item in result)
                {
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
