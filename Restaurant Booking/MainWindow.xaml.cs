using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Restaurant_Booking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListCreator? BookingsList { get; set; } //Jag vill att listan ska gå att komma åt över hela programmet. Därför skapas den här.





        public MainWindow()
        {
            InitializeComponent();
            BookingsList = new ListCreator(); //Skapar listan med förbokningar i ListBoxen
        }

        


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e) //Visar bokningarna.
        {
            ListView.Items.Clear();
            ShowBookings();

        }

        private void GuestName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            string namn = GuestName.Text; //Här vill jag dra ut till en egen klass, för att få det cleanare, men får ListBoxen out of scope.
            DateTime date = DateTime.Parse(DateSelect.Text);
            string time = TimeSelect.Text;
            string table = TableSelect.Text;

            BookingCheck.Check();


            var newBooking = new BookingConstructor(namn, date, time, table);
            ListCreator.BookingsList.Add(newBooking);


            ListView.Items.Add($"Namn: {newBooking.Name} Datum: {newBooking.Date} Tid: {newBooking.Time} Bord: {newBooking.Table}");

            ResetFields();
            
        }

        public void ShowBookings() //Den här hade jag velat dra ut till en separat klass, för att få appen mer clean, men då blir ListBoxen(ListView) out of scope.
        {
            foreach (BookingConstructor item in ListCreator.BookingsList) //Här itererar jag genom de bokningar som finns.
            {
                ListView.Items.Add($"Namn: {item.Name} Datum: {item.Date} Tid: {item.Time} Bord: {item.Table}");

            }


        }

        public void ResetFields() //Återställer alla fält.
        {
            GuestName.Text = "Skriv gästens namn:";
            DateSelect.Text = DateTime.Now.ToString(); //Konverterarar DateTime till en string som kan skrivas i textfältet
            TimeSelect.Text = "Välj tid:";
            TableSelect.Text = "Välj bord:";
            
        }

        private void UnBookButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ListView.SelectedIndex; //Tar bort en bokning genom att hämta markerat index i ListBoxen. Tar sen bort det indexet från bokningslistan.
            ListCreator.BookingsList.RemoveAt(index);
            ListView.Items.Remove(ListView.SelectedItem);
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
