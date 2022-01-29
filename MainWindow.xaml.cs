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
using Microsoft.Win32;
using System.IO;
using basic_report.Models;

namespace basic_report
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainModel mm;
        public MainWindow()
        {
            InitializeComponent();
            mm = new MainModel();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Choose file";
            if (openFileDialog.ShowDialog(this) == true)
            {
                mm.addMunicipio(File.ReadAllLines(openFileDialog.FileName));
                showMunicipios();
            }
        }

        private void showMunicipios()
        {
            gpMunicipio.DataContext = mm.municipioList;
        }
    }
}
