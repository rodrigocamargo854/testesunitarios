using NUnit.Framework;

namespace testearrays.tests 
{
    public class Tests 
    {

        [Test]
        public void Test0 () 
        {
            int s1 = Calculator.Sum (1,2,3,4,5);
            var resultado = s1;
            Assert.That (10, Is.EqualTo (resultado));
        }

        [Test]
        public void Test1 () 
        {
            int s1 = Calculator.Sum (1,2,3,4,5);
            var resultado = s1;
            Assert.That (10, Is.EqualTo (resultado));
        }

        [Test]
        public void Test2 () 
        {
            int s1 = Calculator.Sum (1,2,3,4,5);
            var resultado = s1;
            Assert.That (15, Is.EqualTo (resultado));
        }

        [Test]
        public void Test3 () 
        {
            int s1 = Calculator.Sum (2,3,5);
            var resultado = s1;
            Assert.That (10, Is.EqualTo (resultado));
        }

         [Test]
        public void Test4 () 
        {
            int s1 = Calculator.Sum (1,2,3,7);
            var resultado = s1;
            Assert.That (13, Is.EqualTo (resultado));
        }
    }
}