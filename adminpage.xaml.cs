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
    /// Логика взаимодействия для adminpage.xaml
    /// </summary>
    public partial class adminpage : Page
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgtimedate.Visibility = Visibility;
            dgdata.Visibility = Visibility;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgtimedate.Visibility = Visibility.Hidden;
            dgdata.Visibility = Visibility.Hidden;
        }
    }
}
