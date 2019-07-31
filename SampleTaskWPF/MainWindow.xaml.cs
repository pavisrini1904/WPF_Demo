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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtEmail.Text.Trim().Length==0  && txtName.Text.Trim().Length==0 && txtShopid.Text.Trim().Length==0){
                MessageBox.Show("Please enter values for all the fields");
            }
            else
            {
                HomeWindow nextPage = new HomeWindow();
                nextPage.Show();
                this.Close();
            }
            
        }
    }
}
