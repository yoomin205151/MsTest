using practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class CollectionSampleTest
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "John", LastName = "Ford" },
                                                     new Customer { FirstName = "Billy", LastName = "Wilder" }};

            int index = 1;
            Customer expected = customers[1];

            //act
            Customer actual = CollectionSample.GetCustomer(customers, index);


            //asset
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_SouldThrowIndexOutOfRangeExeption()
        {
            //arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "John", LastName = "Ford" },
                                                     new Customer { FirstName = "Billy", LastName = "Wilder" }};

            int index = 3;

            //act
            CollectionSample.GetCustomer(customers, index);

        }

    }
}
