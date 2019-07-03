using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Task2.Entity;

namespace System_Task2.ViewModel
{
 public class LogViewModel:BaseViewModel
    {
        public LogViewModel()
        {
            ProcessList = new ObservableCollection<ProcessEntity>();
            Read();
        }
     public   void Read()
        {

            if (File.Exists("Process.json"))
            {
                string jsonUsers = File.ReadAllText("Process.json");

                ProcessList = JsonConvert.DeserializeObject<ObservableCollection<ProcessEntity>>(jsonUsers);
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
