using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Booking
{
    public class Booking : IBooking //Min constructor för bokningar. Ärver bokningsinterfacet.
    {
        private string _name;
        private string _time;
        private string _table;
        public string Name
        {
            get { return _name; }
            set //Felhantering
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Din bokning behöver ett namn.");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public DateTime Date { get; set;} //Eftersom DateTime aldrig blir noll behöver jag igen exception på den.
        public string Time {
            get { return _time; }
            set //Felhantering
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Din bokning behöver en tid.");
                }
                else
                {
                    _time = value;
                }
            }
        }
        public string Table {
            get { return _table; }
            set //Felhantering
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Din bokning behöver ett bord.");
                }
                else
                {
                    _table = value;
                }
            }
        }

        //public Booking() { }
     

        public Booking(string name, DateTime date, string time, string table)
        {
            this.Name = name;
            this.Date = date;
            this.Time = time;
            this.Table = table;
        }
    }
}
