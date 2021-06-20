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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

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



            this.Hide();
            backauth maibackn = new backauth();
            maibackn.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->О программе";
            main.Navigate(new helppage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->Торговля";
            main.Navigate(new sale());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->Клиенты";
            main.Navigate(new infoclient());
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->Номенклатура";
            main.Navigate(new uchet());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->Администрирование";
            main.Navigate(new adminpage());
        }
    }
}
