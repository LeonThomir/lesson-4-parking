using System;
using System.Collections.Generic;
namespace lesson_4_parking.Models
{
    public class CarPark
    {
        public List <Customer> listOfCustomers= new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();

        public CarPark()
        {
            Console.WriteLine("New CarPark");
        }

        public override string ToString()
        {
            return "I'm the CarPark";
        }

        public void AddCustomer(Customer newCustomer)
        {
            listOfCustomers.Add(newCustomer);
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharge(customer);
                Console.WriteLine($"Calculating charges for the customer which are {calculatedCharge} euros for registration {customer.registration}");
            }
        }
    }
}
