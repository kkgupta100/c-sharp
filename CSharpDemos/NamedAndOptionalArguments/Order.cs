using System;

namespace NamedAndOptionalArguments
{
    /// <summary>
    /// Example of "Named Arguments"
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Prints order details on console screen.
        /// </summary>
        /// <param name="orderNo">Order Number</param>
        /// <param name="orderDate">Order Date</param>
        /// <param name="productName">Product Name</param>
        /// <param name="custFirstName">First Name of Customer</param>
        /// <param name="custLastName">Last Name of Customer</param>
        public void PrintOrder(int orderNo, DateTime orderDate, string productName, string custFirstName, string custLastName)
        {
            Console.WriteLine($"Order Number: {orderNo}");
            Console.WriteLine($"Order Date: {orderDate:dd-MMM-yyyy}");
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"First Name of Customer: {custFirstName}");
            Console.WriteLine($"Last Name of Customer: {custLastName}");
        }
    }
}