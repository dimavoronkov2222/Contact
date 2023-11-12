using System.Collections.Generic;
using System.Windows;
namespace Contact
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Contacts contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new Contacts();
            DataContext = this;
        }
        public List<Person> People
        {
            get { return contacts.GetPeople(); }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
            if (window1.DialogResult.HasValue && window1.DialogResult.Value)
            {
                contacts.AddPerson(window1.name.Text, window1.surname.Text, window1.address.Text, window1.phonenumber.Text);
            }
        }
    }
}