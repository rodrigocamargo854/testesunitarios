using NUnit.Framework;

namespace testearrays.tests {
    public class Tests {

        [Test]
        public void Test1 () 
        {
            int s1 = Calculator.Sum (new int [] {1,2,3,4,5});
            var resultado = s1;
            Assert.That (10, Is.EqualTo (resultado));
        }
    }
}