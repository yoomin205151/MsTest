using practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class CalcTest
    {
        [DataRow(4,4,8)]
        [DataRow(5, 5, 10)]
        [DataRow(10, 10, 20)]
        [TestMethod]
        public void Sum_ShouldCalcReturnSameValue(int a, int b, int expected)
        {
            //arrange se setean las variables que vamos a utilizar
            //int a = 4;
            //int b = 4;
            //int expected = 8;

            //act se setea el metodo que vamos a utilizar
            int actual = Calcs.Sum(a,b);

            //assert validar lo que queremos que cumpla
            Assert.AreEqual(expected, actual);

        }

    }
}
