using System.Linq;
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
         
        }




    }
}
