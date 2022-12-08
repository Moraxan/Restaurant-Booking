using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Booking
{
    public class ListCreator //Klassen skapar listan och lägger till bokningar som finns från grunden.
    {
        public static List<BookingConstructor> BookingsList = new();
        public DateTime date1 = new(2022, 12, 22); //Här behövs egentligen inte 4 stycken generade dates, eftersom de är samma, men jag använder samma konsekvens som om de hade bokats via appen.
        public DateTime date2 = new(2022, 12, 22);
        public DateTime date3 = new(2022, 12, 22);
        public DateTime date4 = new(2022, 12, 22);
        

        public ListCreator() //Metoden lägger till mina förgenerade bokningar i listan.
        {
            BookingConstructor Booking1 = new("Monika Zetterlund", date1, "18:00", "1");
            BookingConstructor Booking2 = new("Martin Ljung", date2, "18:00", "2");
            BookingConstructor Booking3 = new("Gösta Bernard", date3, "18:00", "3");
            BookingConstructor Booking4 = new("Ulf Peder Olrog", date4, "18:00", "4");

            BookingsList.Add(Booking1);
            BookingsList.Add(Booking2);
            BookingsList.Add(Booking3);
            BookingsList.Add(Booking4);
        }
        
    }
}
