using NUnit.Framework;
using raiz;

namespace raiz.tests

{
    [TestFixture]
    public class CalculaRaiz

    {
        [Test]
        public void DeveRetornarARaizQuadrada () 
        {
            RaizQuadrada r = new RaizQuadrada ();
            var result = r.CalcRaiz (16);
            Assert.That (4, Is.EqualTo (result));
        }

         [Test]
        public void Test2 () 
        {
            RaizQuadrada r = new RaizQuadrada ();
            var result = r.CalcRaiz (16);
            Assert.That (2, Is.EqualTo (result));
        }

    }

}