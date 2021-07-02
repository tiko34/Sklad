using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для sale.xaml
    /// </summary>
    public partial class sale:Page
    {
        public sale()
        {

            InitializeComponent();
            DT sl = new DT();
            tabletovar.ItemsSource = skladEntities.GetContext().товар.ToList();

        }

        private void dekbtn_Click(object sender,System.Windows.RoutedEventArgs e)
        {
            if(MessageBox.Show($"Вы точно хотите удалить следуюшие записи?","Внимание!",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes) 
            {
                try
                {
                    var Removin = tabletovar.SelectedItems.Cast<товар>().ToList();
                    skladEntities.GetContext().товар.RemoveRange(Removin);
                    skladEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    tabletovar.ItemsSource = null;
                    tabletovar.ItemsSource = skladEntities.GetContext().товар.ToList();
                }
                catch(Exception )
                {
                    MessageBox.Show("Ошибка удаления","Ошибка",MessageBoxButton.OK);
                }
            }
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            MainWindow.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Торговля->Добавление товара";
            openpage.MainFrame.Navigate(new edda1());
        }

        private void Button_Click_1(object sender,RoutedEventArgs e)
        {
            MainWindow.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Торговля->оформление";
            openpage.MainFrame.Navigate(new oformlenie());
        }
    }
}
