using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Task2.Entity;

namespace System_Task2.ViewModel
{
   public class ConfigurationViewModel:BaseViewModel
    {

       public  ConfigurationViewModel ()
        {
            if (File.Exists("Process.json"))
            {
                string jsonUsers = File.ReadAllText("Users.json");
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
