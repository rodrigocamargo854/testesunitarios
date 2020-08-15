using calculo_2;
using NUnit.Framework;

namespace calculo_2.tests {

    [TestFixture]
    public class calculo2 {

        [Test]
        public void Test1 ()

        {
            Calculadora2 c = new Calculadora2 ();
            var resultado = c.Potencia (2, 2);

            Assert.That (4, Is.EqualTo (resultado));
        }
    }
}