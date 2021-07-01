using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для sale.xaml
    /// </summary>
    public partial class sale : Page
    {
        public sale()
        {
          
            InitializeComponent();
            DT sl = new DT();
            tabletovar.ItemsSource = skladEntities.GetContext().товар.ToList();
            cmbclient.ItemsSource = skladEntities.GetContext().Клиенты.ToList();
            string cmb = (string)cmbclient.SelectedItem;
        }

        private void dekbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите удалить следуюшие записи?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) ;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
