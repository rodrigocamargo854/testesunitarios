using NUnit.Framework;

namespace testearrays.tests 
{
    public class Tests 
    {

        [Test]
        public void DeveRetornarValorFAtorialDe4 () 
        {
            int s1 = Calculator.Fator (1,2,3,4);
            var resultado = s1;
            Assert.That (10, Is.EqualTo (resultado));
        }

        [Test]
        public void DeveRetornarValorFAtorialDe5 () 
        {
            int s1 = Calculator.Fatorial (1,2,3,4,5);
            var resultado = s1;
            Assert.That (120, Is.EqualTo (resultado));
        }

        [Test]
        public void DeveRetornarValorFAtorialDe7 () 
        {
            int s1 = Calculator.Fatorial (1,2,3,4,5,6,7);
            var resultado = s1;
            Assert.That (15, Is.EqualTo (resultado));
        }

        [Test]
        public void DeveRetornarValorFAtorialDe6 () 
        {
            int s1 = Calculator.Fatorial(1,2,3,4,5,6);
            var resultado = s1;
            Assert.That (30, Is.EqualTo (resultado));
        }

         [Test]
        public void DeveRetornarValorFAtorialDe8 () 
        {
            int s1 = Calculator.Fatorial (1,2,3,4,5,6,7,8);
            var resultado = s1;
            Assert.That (13, Is.EqualTo (resultado));
        }
    }
}