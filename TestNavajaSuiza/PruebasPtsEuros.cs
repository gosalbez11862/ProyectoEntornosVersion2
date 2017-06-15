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
            //Escenario de Prueba
            double cantidadPesetas = 10000;
            double resultadoEsperado = 1663800;
            double resultadoObtenido;

            //Acción a Probar
            resultadoObtenido = CPtsEuros.FConversorpta(cantidadPesetas);

            //Afirmación de la Prueba
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen pta "monedas"
        /// con valor de hasta cuatro digitos, ya que el textBox solo permite la entrada
        /// no superior a 4 digitos
        /// </summary>

        [TestMethod]
        public void ControlarPtaMaxvalue()
        {
            double Pta = 9999;
            double resultadoEsperado = 1663633.62;

            var resultadObtenido = CPtsEuros.FConversorpta(Pta);

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
            //Escenario de Prueba
            double cantidadEuros = 6;
            double resultadoEsperado = 0.0360620266858998;
            double resultadoObtenido = 0;

            //Acción a Probar
            resultadoObtenido = CPtsEuros.FConversoreu(cantidadEuros);

            //Afirmación de la Prueba
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        /// <summary>
        /// Ejercicio 4.
        /// Controlar que no pasen euros "monedas"
        /// con valor de hasta cuatro digitos, ya que el textBox solo permite la entrada
        /// no superior a 4 digitos
        /// </summary>
        
        [TestMethod]
        public void ControlarEurosMaxvalue()
        {
            double euros = 9999;
            double resultadoEsperado = 60.0973674720519;

            var resultadObtenido = CPtsEuros.FConversoreu(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
