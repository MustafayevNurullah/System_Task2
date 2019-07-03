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
        public ConfigurationViewModel()
        {
            process = new List<string>
            {
                "Calculator",
                "Untitled - Paint",
            };
        }

        public static List<string> process { get; set; }

    }
}
