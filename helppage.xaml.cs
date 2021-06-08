using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для helppage.xaml
    /// </summary>
    public partial class helppage : Page
    {
        public helppage()
        {
            InitializeComponent();
        }

        

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/tiko34/Sklad.git"); //открытие ссылки в браузере
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://t.me/Walker3471"); //открытие ссылки в браузере
        }
    }
}
