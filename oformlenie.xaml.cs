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

            //Добавляет запись в табл заказ, обязательно включает в себя табл товар_заказ
            try
            {
                DT sql = new DT();
                int opl = 0;
                if(cvb.SelectedIndex == 0)
                {
                    opl = 2;

                }
                else
                {
                    opl = 1;
                }  
                int cl = Convert.ToInt32(clbo.Text);
             //   float sm = 5;
                string st = Convert.ToString(DateTime.Now);// дата сейчас

            /// добавление заказ
           string yh = Convert.ToString(prim.Text);//примечание
          
            int idtovr = Convert.ToInt32(tovar.Text);
            int kolvo = Convert.ToInt32(lok.Text);//колво
            string edizm = Convert.ToString(edi.Text);//
            int thaed = Convert.ToInt32(stoim.Text);//за ед товара
            int smm = kolvo * thaed;
            sql.Select($@"INSERT INTO заказ (idклиент, ВидОплаты, датасоставления,общаясумма) VALUES('{cl}','{opl}', '{st}' ,'{smm}')");
            int idx = 23;

            // добавление товар_заказ
            sql.Select($@"INSERT INTO Товар_Заказ (Наименование, idЗаказ, idТовар,колво,едизм,стоимзаед) VALUES('{yh}','{idx}', '{idtovr}' ,'{kolvo}','{edizm}','{thaed}')");












            //////успех
            MessageBox.Show("Успех","Данные добавлены",MessageBoxButton.OK);
            openpage.MainFrame.Navigate(new sale());
            Window.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Торговля";
        }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления записи", "Ошибка", MessageBoxButton.OK);

            }





}

    }
}
