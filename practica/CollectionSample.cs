using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class CollectionSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }

    }

    public class  Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
