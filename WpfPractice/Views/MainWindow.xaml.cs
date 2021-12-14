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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPractice.Models;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PersonModel> people { get; set; }
        public PersonModel CurrentSelectedPerson { get; set; }
        public MainWindow()
        {
            people = new ObservableCollection<PersonModel>();
            CurrentSelectedPerson = new PersonModel();

            this.DataContext = this;

            InitializeComponent();

            people.Add(new PersonModel("Joe"));
            people.Add(new PersonModel("Sandra"));
            people.Add(new PersonModel("Louis"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            people.Add(new PersonModel(textbox1.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            people.Remove((PersonModel)listbox1.SelectedItem);  
        }

        private void listbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
