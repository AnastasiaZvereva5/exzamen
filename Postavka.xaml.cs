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
using System.Windows.Shapes;

namespace tren1
{
    /// <summary>
    /// Логика взаимодействия для Postavka.xaml
    /// </summary>
    public partial class Postavka : Window
    {
        public Postavka()
        {
            InitializeComponent();
        }
        private void Obratno(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Close();
        }
    }
}
