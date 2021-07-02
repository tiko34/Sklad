using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для oformlenie.xaml
    /// </summary>
    public partial class oformlenie : Page
    {
        public oformlenie()
        {
            InitializeComponent();
         












        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {


           try
           {
                DT sql = new DT();
                int cl = Convert.ToInt32(clbo.Text);
                int opl = Convert.ToInt32(vid.Text);
                float sm = (float)Convert.ToDouble(sim.Text);
            string st = Convert.ToString(DateTime.Now);

                sql.Select($@"INSERT INTO заказ (idклиент, ВидОплаты, датасоставления,общаясумма) VALUES('{cl}','{opl}', '{st}' ,'{sm}')");
                MessageBox.Show("Успех", "Данные добавлены", MessageBoxButton.OK);
                openpage.MainFrame.Navigate(new sale());
                Window.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Торговля";
              
         }
           catch (Exception)
          {
              MessageBox.Show("Ошибка", "Обратитесь к разработчику", MessageBoxButton.OK);
               
           }
            




        }
    }
}
