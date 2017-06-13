using NavajaSuiza.Ejercicio4;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebasPtsEuros
    {
        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen pesetas "monedas"
        /// con valor negativo
        /// </summary>
        
        [TestMethod]
        public void ControlarPesetasNegativos()
        {
            double pesetas = -1;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = CPtsEuros.FConversorpta(pesetas);

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
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = CPtsEuros.FConversorpta(pesetas);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen euros "monedas"
        /// con valores negativos
        /// </summary>
        
        [TestMethod]
        public void ControlarEurosNegativo()
        {
            double euros = -10;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = CPtsEuros.FConversoreu(euros);

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
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = CPtsEuros.FConversoreu(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
