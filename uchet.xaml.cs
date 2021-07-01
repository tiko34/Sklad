using System;
using System.Windows;
using System.Windows.Controls;

namespace Sklad
{
   
    public partial class uchet : Page
    {
        public uchet()
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
                 ed =null;
                 kol = 0;
                 
                MessageBox.Show("Товар добавлен в базу", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления данных в базу","Ошибка",MessageBoxButton.OK,MessageBoxImage.Warning);
            }


        }
    }
}
