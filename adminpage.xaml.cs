using System.Windows;
using System.Windows.Controls;

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
