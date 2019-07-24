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

namespace Wpf_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student = new Student() { Name = "Delpin", Age = 24};
        List<Person> persons = new List<Person>();    
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = student;
            persons.Add(new Person { Name = "Delpin" });
            persons.Add(new Person { Name = "Ravi" });
            persons.Add(new Person { Name = "Raj" });
            persons.Add(new Person { Name = "Jerome" });
            lstPersons.ItemsSource = persons;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    lblName.Content = student.Name;
        //    lblAge.Content = student.Age;
        //}
    }

    public class Person
    {
        public string Name{ get; set; }
    }
    public class Student
    {
        private string nameValue;

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        private int ageValue;

        public int Age
        {
            get { return ageValue; }

            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }
    }
}
