using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для uchet.xaml
    /// </summary>
    public partial class uchet : Page
    {
        public uchet()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DT sl = new DT();
            string stoim = stoimtb.Text;
            string name = nametb.Text;
            string ed = edtb.Text;
            string kol = koltb.Text;
        
          


         //   sl.Select($@"INSERT INTO товар (Наименование,СтоимЗаЕд,ЕдИзм,[кол-во],наличие) VALUES ('{name}', '{kol}','{ed}','{inn}')");
        }
    }
}
