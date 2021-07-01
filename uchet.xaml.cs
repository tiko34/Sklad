using System.Windows;
using System.Windows.Controls;

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
