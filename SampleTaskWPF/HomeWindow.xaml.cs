using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace SampleTaskWPF
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public ObservableCollection<DetailsModel> detailsModel;
        List<DetailsModel> items = new List<DetailsModel>();

        public HomeWindow()
        {
            InitializeComponent();
            items.Add(new DetailsModel() { Country = "India", City="Tamil Nadu", State = "Kumbakonam"});
            items.Add(new DetailsModel() { Country = "Malaysia", City="Johor", State = "Batu Pahat"});
            items.Add(new DetailsModel() { Country = "India", City = "Kerala", State = "Alapuzha" });
            items.Add(new DetailsModel() { Country = "Maldives", City="Baa Btholhu", State = "Eydhafushi"});
            lstDetails.ItemsSource = items;

            HomeWindowHeaderControl homeWindowHeaderControl = new HomeWindowHeaderControl();
            homeWindowHeaderControl.imgLogout.MouseDown += ImgLogout_MouseDown;
        }

        private void ImgLogout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("img clicked");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtCity.Text.Trim().Length == 0 && txtCountry.Text.Trim().Length == 0 && txtState.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter values for all the fields");
            }
            else
            {
                lstDetails.ItemsSource = null;
                items.Add(new DetailsModel()
                {
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    State = txtState.Text
                });
                lstDetails.ItemsSource = items;
                txtCountry.Text = null;
                txtCity.Text = null;
                txtState.Text = null;
            }
            
        }

        private void btnRemoveList_Click(object sender, RoutedEventArgs e)
        {
            Border cmd = (Border)sender;
            if (cmd.DataContext is DetailsModel)
            {

                DetailsModel deleteme = (DetailsModel)cmd.DataContext;
                items.Remove(deleteme);
                lstDetails.ItemsSource = null;
                lstDetails.ItemsSource = items;
            }
        }

        
    }
}
