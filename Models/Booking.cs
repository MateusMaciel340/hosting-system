using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hosting_system.Models
{
    public class Booking
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Booking() {}

        public Booking(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void AddingGuests(List<Person> guests)
        {
            if (true)
            {
                Guests = guests;
            }
            else
            {
                
            }
        }

        public void AddingSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetQuantityGuests()
        {
            return 0;
        }

        public decimal CalculateDailyValue()
        {
            decimal valor = 0;

            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}