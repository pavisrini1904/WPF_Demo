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
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            lstDetails.ItemsSource = null;
            items.Add(new DetailsModel() {
                Country = txtCountry.Text,
                City = txtCity.Text,
                State = txtState.Text
            });
            lstDetails.ItemsSource = items;
            txtCountry.Text = null;
            txtCity.Text = null;
            txtState.Text = null;
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

        //private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    int selectedIndex = lstDetails.SelectedIndex;

        //    lstDetails.Items.Remove(lstDetails.SelectedItem);
        //}


        //private void BtnRemoveItem(object sender, MouseEventArgs e)
        //{
        //    //Console.WriteLine("Index: " + listBox.Items.IndexOf(sender));
        //    int currentindex;
        //    var result = sender as ListBoxItem;
        //    for (int i = 0; i < lstDetails.Items.Count; i++)
        //    {
        //        if ((lstDetails.Items[i] as ListBoxItem).Content.ToString().Equals(result.Content.ToString()))
        //        {
        //            currentindex = i;
        //            break;
        //        }
        //    }

        //    //To get the selected ListItem
        //    //ListBoxItem item = (ListBoxItem)lstDetails.ItemContainerGenerator.ContainerFromIndex(lstDetails.SelectedIndex);
        //}
    }
}
