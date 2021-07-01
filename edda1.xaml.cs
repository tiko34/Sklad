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
    /// Логика взаимодействия для edda1.xaml
    /// </summary>
    public partial class edda1 : Page
    {
        public edda1()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DT sl = new DT();
         
                

            try
            {
                int stoim = Convert.ToInt32(stoimtb.Text);
                string name = nametb.Text;
                string ed = edtb.Text;
                int kol = Convert.ToInt32(koltb.Text);
                int es = 1;

                sl.Select($@"INSERT INTO товар ([кол-во],ЕдИзм,СтоимЗаЕд,наличие,Наименование) VALUES ('{kol}','{ed}','{stoim}', '{es}','{name}')");
                stoim = 0;
                name = null;
                ed = null;
                kol = 0;

                MessageBox.Show("Товар добавлен в базу", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления данных в базу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        
    }

    }
}
