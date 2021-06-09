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

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            openpage.MainFrame = main;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exit_window exit_win = new exit_window();
            exit_win.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main.Navigate(new helppage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            main.Navigate(new sale());
        }
    }
}
