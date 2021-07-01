using System.Windows;

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

      

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(main).Title = "Оптовый склад->Администрирование";
            main.Navigate(new adminpage());
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
          //  Hide();
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
