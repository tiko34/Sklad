using System;
using System.Data;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          
            if (MessageBox.Show($"Вы точно хотите удалить следуюшие запсии", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) ;
            {
                try
                {
                    var Removing = infoclientdb.SelectedItems.Cast<Клиенты>().ToList();
                    skladEntities.GetContext().Клиенты.RemoveRange(Removing);
                    skladEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    infoclientdb.ItemsSource = null;
                    infoclientdb.ItemsSource = skladEntities.GetContext().Клиенты.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
