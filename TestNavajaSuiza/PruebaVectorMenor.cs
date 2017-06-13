using NavajaSuiza.Ejercicio3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebaVectorMenor
    {
        /// <summary>
        /// Ejercicio 3.
        /// Comprobar si soporta el vector numeros MinValue
        /// </summary>
        [TestMethod]
        public void ControlarMenorVectorMaxValue()
        {
            NumeroVectorMenor nmVector = new NumeroVectorMenor();

            int vector = int.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nmVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 3.
        /// Comprobar si soporta el vector numeros MinValue
        /// </summary>
        [TestMethod]
        public void ControlarMenorVectorMinValue()
        {
            NumeroVectorMenor nmVector = new NumeroVectorMenor();

            int vector = int.MinValue;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nmVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
