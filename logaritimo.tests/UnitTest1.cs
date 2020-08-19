using testearrays;
using NUnit.Framework;

namespace logaritimo.tests 
{
    [TestFixture]
    public class Tests 
    {

        [Test]
        public void DeveRetornarSomaDosArrays () 
        {
            TesteArrays c = new TesteArrays ();
            double[] t = new double[1,2,3,4];
            var resultado = c.SomaArrays(t );
            Assert.That (10, Is.EqualTo (resultado));
        }
    }
    
}