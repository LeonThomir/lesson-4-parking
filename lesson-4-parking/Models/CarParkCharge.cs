using System;
namespace lesson_4_parking.Models
{
    public class CarParkCharge
    {
        public int minimumfee { get; set; }
        public int minimumhours { get; set; }


        public CarParkCharge(int _minimumfee=2, int _minimumhours=3)
        {
            Console.WriteLine("New CarParkCharge");
            minimumfee = _minimumfee;
            minimumhours = _minimumhours;
        }

        public override string ToString()
        {
            return "I'm the CarParkCharge";
        }
        public int CalculateCharge(Customer customer)
        {
            int calculatedfee = customer.hoursParked < minimumhours ? minimumfee : minimumfee * customer.hoursParked;
            return calculatedfee;
        }
    }
}
