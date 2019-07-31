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
namespace SampleTaskWPF
{
    /// <summary>
    /// Interaction logic for HomeWindowHeaderControl.xaml
    /// </summary>
    public partial class HomeWindowHeaderControl : UserControl
    {
        public HomeWindowHeaderControl()
        {
            InitializeComponent();
        }

        private void ImgLogout_MouseDown(object sender, RoutedEventArgs e)
        {

            MainWindow nextPage = new MainWindow();
            nextPage.Show();

            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
        }
    }
}
