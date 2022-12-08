using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Restaurant_Booking
{
    internal class BookingCheck
    {
        public static void Check()
        {
            if (ListCreator.BookingsList[0].Date == ListCreator.BookingsList.Last().Date) //Behöver kolla alla element i listan OR är en bra operator.
            {
                MessageBox.Show("Den tiden är tyvärr redan bokad. Försök igen.");
            }
            //Jag behöver ta användaren till början och den ska inte logga någon bokning.
        }


    }
}
