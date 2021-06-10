using System;
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

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для exit_window.xaml
    /// </summary>
    public partial class exit_window : Window
    {
        public exit_window()
        {
            InitializeComponent();
            MainWindow.GetWindow(openpage.MainFrame).IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(openpage.MainFrame).IsEnabled = true;
            Close();
        }
    }
}
