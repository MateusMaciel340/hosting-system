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

        public Booking() { }

        public Booking(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void AddingGuests(List<Person> guests)
        {
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new ArgumentException("Essa suite tem a capacidade insuficiente para hospedes!");
            }
        }

        public void AddingSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetQuantityGuests()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal valueCalculate = Suite.DailyValue * ReservedDays;

            if (ReservedDays >= 10)
            {
                valueCalculate = valueCalculate - (valueCalculate * 0.10M);
            }

            return valueCalculate;
        }
    }
}