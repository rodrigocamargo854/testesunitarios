using calculo_2;
using NUnit.Framework;

namespace calculo_2.tests 

{

    [TestFixture]
    public class calculo2
    
     {

        [Test]
        public void DeveRetornaOvalorDeUmaPotencia ()

        {
            Potencia c = new Potencia ();
            var resultado = c.CalculaPotencia (2, 2);

            Assert.That (4, Is.EqualTo (resultado));
        }
    }
}