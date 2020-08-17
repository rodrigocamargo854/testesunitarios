using logaritimo;
using NUnit.Framework;

namespace logaritimo.tests 
{
    [TestFixture]
    public class Tests 
    {

        [Test]
        public void Test1 () 
        {
            Calculalog c = new Calculalog ();
            var resultado = c.Log (3);
            Assert.That (0.47712125471966243729502790325512, Is.EqualTo (resultado));
        }
    }
    
}