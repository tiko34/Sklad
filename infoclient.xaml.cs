using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для infoclient.xaml
    /// </summary>
    public partial class infoclient : Page
    {
        public infoclient()
        {
            InitializeComponent();
            infoclientdb.ItemsSource = skladEntities.GetContext().Клиенты.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Клиенты->Регистрация клиента";
            openpage.MainFrame.Navigate(new regclient());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
