using calculos;
using NUnit.Framework;


namespace calculos.tests 

{
    [TestFixture]
    public class Calctest
     {

        [Test]
        public void Soma_DeveRetornarOValorCorreto () 
        {
            Calculadora c = new Calculadora ();

            var resultadoSom = c.Soma (10, 20);
            var resultadoSub = c.Subtracao (10, 20);
            var resultadoMult = c.Multiplicacao (10, 20);
            var resultadoDiv = c.Divisao (20, 20);

            //Verifica se o primeiro parametro é igual ao segundo
            Assert.AreEqual (30, resultadoSom);
            Assert.AreEqual (-10, resultadoSub);
            Assert.AreEqual (200, resultadoMult);
            Assert.AreEqual (1, resultadoDiv);

        }
    }
}