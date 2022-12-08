using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Booking
{
    public class BookingConstructor : IBooking //Min constructor för bokningar. Ärver bokningsinterfacet.
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Table { get; set; }
     

        public BookingConstructor(string name, DateTime date, string time, string table)
        {
            this.Name = name;
            this.Date = date;
            this.Time = time;
            this.Table = table;
;
        }
    }
}
