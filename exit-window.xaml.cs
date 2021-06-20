using System.Windows;

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
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Application.Current.Shutdown(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            auth authwinn = new auth();
            authwinn.Show();
            Close();
           
          
            
        }
    }
}
