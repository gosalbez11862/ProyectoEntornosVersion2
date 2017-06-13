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
            ConvertirPtsEuros conversor = new ConvertirPtsEuros();

            double pesetas = -1;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = conversor.ComprobarPesetas(pesetas);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen pesetas "monedas"
        /// con valor maxvalue
        /// </summary>
        
        [TestMethod]
        public void ControlarPesetasMaxValue()
        {
            ConvertirPtsEuros conversor = new ConvertirPtsEuros();

            double pesetas = double.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = conversor.ComprobarPesetas(pesetas);

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
            ConvertirPtsEuros conversor = new ConvertirPtsEuros();

            double euros = -10;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = conversor.ComprobarEuros(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen euros "monedas"
        /// con valor Maxvalue
        /// </summary>
        
        [TestMethod]
        public void ControlarEurosMaxvalue()
        {
            ConvertirPtsEuros conversor = new ConvertirPtsEuros();

            double euros = double.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = conversor.ComprobarEuros(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
