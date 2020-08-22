using calculos;
using NUnit.Framework;


namespace calculos.tests

{
    [TestFixture]
    public class CalcTest
    {

        [TestCase(3, 5, 8)]
        [TestCase(2, 1, 3)]
        [TestCase(3, 3, 6)]
        [TestCase(3, 9, 12)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 0, -1)]
        [TestCase(-3, -3, -6)]
        [TestCase(3, -5, -2)]
        [TestCase(-3, 5, 2)]
        [TestCase(2, -2, 0)]

        public void DeveRetornarSomaDeDoisValores(int n1, int n2, int result)
        {
            CalculadoraSoma c = new CalculadoraSoma();

            var resultadoSom = c.Somar(n1, n2);

            //Verifica se o primeiro parametro é igual ao segundo
            Assert.AreEqual(result, resultadoSom);

        }


    }
}

