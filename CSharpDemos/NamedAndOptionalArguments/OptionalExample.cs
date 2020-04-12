using System;
using System.Linq;
using NamedAndOptionalArguments.Data;

namespace NamedAndOptionalArguments
{
    public class OptionalExample
    {
        /// <summary>
        /// Prints active customers on console screen.
        /// </summary>
        public void PrintActiveCustomers()
        {
            var activeCustomersList = CustomersData.GetAllCustomers().Where(c => c.IsActive == true);
            foreach (var customer in activeCustomersList)
            {
                Console.WriteLine($"ID: {customer.ID}\tName: {customer.Name}");
            }
        }

        /// <summary>
        /// Prints inactive customers on console screen.
        /// </summary>
        public void PrintInactiveCustomers()
        {
            var inactiveCustomersList = CustomersData.GetAllCustomers().Where(c => c.IsActive == false);
            foreach (var customer in inactiveCustomersList)
            {
                Console.WriteLine($"ID: {customer.ID}\tName: {customer.Name}");
            }
        }
    }
}