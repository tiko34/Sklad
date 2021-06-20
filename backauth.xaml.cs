using System.Windows;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для backauth.xaml
    /// </summary>
    public partial class backauth : Window
    {
        public backauth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            auth exit_win = new auth();
            exit_win.Show();
            Hide();
        }
    }
}
