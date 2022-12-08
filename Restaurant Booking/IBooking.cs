using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Booking
{
    internal interface IBooking
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Table { get; set; }

    }
}
