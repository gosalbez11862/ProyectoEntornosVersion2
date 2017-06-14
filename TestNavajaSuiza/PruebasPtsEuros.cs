using NavajaSuiza.Ejercicio4;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebasPtsEuros
    {
        /// <summary>
        /// Ejercicio 4.
        /// Controlar que pasa un numero aleatorio,
        /// dado que los negativos nunca podran pasar
        /// </summary>
        
        [TestMethod]
        public void ControlarPesetas()
        {
            double pesetas = 166.38;
            int resultadoEsperado = 1;

            //Prueba
            var resultadObtenido = CPtsEuros.FConversoreu(pesetas);

            //Assert o afirmacion
            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen pesetas "monedas"
        /// con valor de has ta cuatro digitos, ya que el textBox solo permite la entrada
        /// no superior a 4 digitos
        /// </summary>

        [TestMethod]
        public void ControlarPesetasMaxValue()
        {
            double pesetas = 9999;
            double resultadoEsperado = 60.10;

            var resultadObtenido = CPtsEuros.FConversoreu(pesetas);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que pasa un numero aleatorio,
        /// dado que los negativos nunca podran pasar
        /// </summary>

        [TestMethod]
        public void ControlarEuros()
        {
            double euros = 1;
            double resultadoEsperado = 166.38;

            var resultadObtenido = CPtsEuros.FConversoreu(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen euros "monedas"
        /// con valor de has ta cuatro digitos, ya que el textBox solo permite la entrada
        /// no superior a 4 digitos
        /// </summary>
        
        [TestMethod]
        public void ControlarEurosMaxvalue()
        {
            double euros = 9999;
            double resultadoEsperado = 1663633.62;

            var resultadObtenido = CPtsEuros.FConversoreu(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        [TestMethod]
        public void ControlarEurosNegativos()
        {
            int euros = -1;
            ConvertirPtsEuros conversor = new ConvertirPtsEuros();

            double resultado = conversor.ComprobarEuros(euros);

            Assert.IsNotNull(resultado);
        }
    }
}
