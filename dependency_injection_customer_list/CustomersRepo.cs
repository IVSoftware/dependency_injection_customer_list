using System.Collections.Generic;
using System.ComponentModel;

namespace DL
{
    public interface IRepo<T>
    {
        List<T> GetAllMock();
        List<T> NewQueryMock(string sql);
    }
    public class CustomersRepo : IRepo<Customer>
    {
        /// <summary>
        /// Mock a recordset corresponding to 
        /// @"SELECT * FROM CUSTOMERS";
        /// </summary>z
        public List<Customer> GetAllMock() => new List<Customer>
        {
            new Customer{ FirstName = "Tom", LastName = "Hanks"},
            new Customer{ FirstName = "Tom", LastName = "Cruise"},
            new Customer{ FirstName = "Tom", LastName = "Holland"},
        };

        public List<Customer> NewQueryMock(string sql) => new List<Customer>
        {
            new Customer{ FirstName = "Other", LastName = "Customer"},
        };
    }

    public class Customer
    {
        [Browsable(false)]
        public string Guid { get; set; } = System.Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
