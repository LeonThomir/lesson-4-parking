using System;
namespace lesson_4_parking.Models
{
    public class Customer
    {

        public int hoursParked {get; set;}

        public string registration { get; set; }

       public Customer(string _registration, int _hoursParked)
        {
            Console.WriteLine($"New Customer {_registration}");
            hoursParked = _hoursParked;
            registration = _registration;
        }

        public override string ToString()
        {
            return "I'm the Customer";
        }
    }
}
