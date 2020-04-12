using System.Collections.Generic;

namespace NamedAndOptionalArguments.Data
{
    public static class CustomersData
    {
        /// <summary>
        /// Returns list of customers.
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetAllCustomers()
        {
            //initialize list
            var listToReturn = new List<Customer>();
            
            //prepare list
            listToReturn.Add(new Customer() { ID = 1, Name = "John", IsActive = true });
            listToReturn.Add(new Customer() { ID = 2, Name = "Joel", IsActive = true });
            listToReturn.Add(new Customer() { ID = 3, Name = "Alex", IsActive = false });
            listToReturn.Add(new Customer() { ID = 4, Name = "Ben", IsActive = true });
            listToReturn.Add(new Customer() { ID = 5, Name = "Harry", IsActive = false });
            listToReturn.Add(new Customer() { ID = 6, Name = "Rosy", IsActive = true });
            listToReturn.Add(new Customer() { ID = 7, Name = "Rony", IsActive = false });
            listToReturn.Add(new Customer() { ID = 8, Name = "Harris", IsActive = true });

            //return list
            return listToReturn;
        }
    }
}