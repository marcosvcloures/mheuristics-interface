﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Interface.View
{
    /// <summary>
    /// Interaction logic for LoadData.xaml
    /// </summary>
    public partial class HeuristicsView : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Interface.MainWindow mainWindow;
        public Heuristics.HeuristicsBase Heuristic;

        public HeuristicsView()
        {
            InitializeComponent();
        }

        private void GA_Click(object sender, RoutedEventArgs e)
        {
            step1.Visibility = Visibility.Hidden;

            step2.Children.Add(new View.GeneticAlgorithm { mainWindow = mainWindow, Heuristics = Heuristic });

            step2.Visibility = Visibility.Visible;
        }

        private void SA_Click(object sender, RoutedEventArgs e)
        {
            step1.Visibility = Visibility.Hidden;

            step2.Children.Add(new View.SimulatedAnnealing { mainWindow = mainWindow, Heuristics = Heuristic });

            step2.Visibility = Visibility.Visible;
        }
    }
}
