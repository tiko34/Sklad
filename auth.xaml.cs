using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        public auth()
        {
            InitializeComponent();
            try
            {
                DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                                // подключаемся к базе данных
                SqlConnection sqlConnection = new SqlConnection("data source = homeserver27rus.ddns.net; initial catalog = sklad; user id = user_kursach; password = 1234567890Asd; MultipleActiveResultSets = True; App = EntityFramework");
                sqlConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету, либо обратитесь к разработчику", "Ошибка", MessageBoxButton.OK);

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DT sl = new DT();
            DataTable dt_user = sl.Select("SELECT Log,pass,приоритет FROM [Операторы]");
            MainWindow main = new MainWindow();
            infoclient cl = new infoclient();
            for (int i = 0; i < dt_user.Rows.Count; i++)
            { 
              if (AuthLogin.Text == Convert.ToString(dt_user.Rows[i][0]) && AuthPass.Text == Convert.ToString(dt_user.Rows[i][1]))
                  {
                    if ((AuthLogin.Text == Convert.ToString(dt_user.Rows[i][0])) && (Convert.ToInt32(dt_user.Rows[i][2]) == 1))
                    { 
                        main.admn.Visibility = Visibility.Visible;  
                        cl.delclient.Visibility = Visibility.Visible;
                        Hide();
                        main.Show();
                    }
                    else 
                    { Hide();
                  
                    main.Show();}
                 
                   }
           }

           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            exit_window exit_win = new exit_window();
            exit_win.Show();
          
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Hide();
            exit_window exit_win = new exit_window();
            exit_win.Show();
        }
    }
}
