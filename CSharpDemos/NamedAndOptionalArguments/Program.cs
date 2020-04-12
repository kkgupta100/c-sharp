using System;

namespace NamedAndOptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderObj = new Order();
            orderObj.PrintOrder(orderNo: 101, new DateTime(2020, 04, 10), "MS Office", "Kishan", "Gupta");

            Console.ReadLine();
        }
    }
}