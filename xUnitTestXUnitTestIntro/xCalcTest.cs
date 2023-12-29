using practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestXUnitTestIntro
{
    public class xCalcTest
    {
        [Fact]
        public void Sum_ShouldCalcReturnSameValue()
        {
            //arrange se setean las variables que vamos a utilizar
            int a = 4;
            int b = 4;
            int expected = 8;

            //act se setea el metodo que vamos a utilizar
            int actual = Calcs.Sum(a, b);

            //assert validar lo que queremos que cumpla
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4,4,8)]
        public void Sum_ShouldCalcReturnSameValueTheory(int a, int b, int expected)
        {
            //arrange se setean las variables que vamos a utilizar

            //act se setea el metodo que vamos a utilizar
            int actual = Calcs.Sum(a, b);

            //assert validar lo que queremos que cumpla
            Assert.Equal(expected, actual);

        }

        [Fact]
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
            Assert.IsType<Customer>(actual);
            Assert.Equal(expected, actual);

        }
    }
}
