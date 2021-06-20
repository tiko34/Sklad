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


        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("data source = homeserver27rus.ddns.net; initial catalog = sklad; user id = user_kursach; password = 1234567890Asd; MultipleActiveResultSets = True; App = EntityFramework");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }


      

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            



            DataTable dt_user = Select("SELECT Log,pass FROM [Операторы]"); 
            for (int i = 0; i < dt_user.Rows.Count; i++)
            { 
              if (AuthLogin.Text == Convert.ToString(dt_user.Rows[i][0]) && AuthPass.Text == Convert.ToString(dt_user.Rows[i][1]))
                  {
                    
                 Hide();
                   MainWindow main = new MainWindow();
                    main.Show();
                   }
           }

           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            exit_window exit_win = new exit_window();
            exit_win.Show();
          
        }
    }
}
