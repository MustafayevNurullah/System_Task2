﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System_Task2.ViewModel;

namespace System_Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ConfigurationView : Window
    {
        public ConfigurationView()
        {
            InitializeComponent();
            ConfigurationViewModel configurationViewModel = new ConfigurationViewModel();
            DataContext = configurationViewModel;



        }
    }
}