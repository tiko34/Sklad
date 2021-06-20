using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            //



            // DataTable dt_user = Select("SELECT Log,pass FROM [Операторы]");
        }




    }
}
