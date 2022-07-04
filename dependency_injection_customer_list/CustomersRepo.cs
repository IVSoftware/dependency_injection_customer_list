using System.Collections.Generic;
using System.ComponentModel;

namespace DL
{
    public interface IRepo<T>
    {
        List<T> GetAllMock();
    }
    public class CustomersRepo : IRepo<Customer>
    {
        /// <summary>
        /// Mock a recordset corresponding to 
        /// @"SELECT * FROM CUSTOMERS";
        /// </summary>
        public List<Customer> GetAllMock()
        {
            List<Customer> customers = new List<Customer>();

            // MOCK
            return new List<Customer>
            {
                new Customer{ FirstName = "Tom", LastName = "Hanks"},
                new Customer{ FirstName = "Tom", LastName = "Cruise"},
                new Customer{ FirstName = "Tom", LastName = "Holland"},
            };
        }
    }

    public class Customer
    {
        [Browsable(false)]
        public string Guid { get; set; } = System.Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
