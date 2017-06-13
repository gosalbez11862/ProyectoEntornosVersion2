using NavajaSuiza.Ejercicio2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebaLecturaVector
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros Maxvalue
        /// </summary>

        [TestMethod]
        public void ControlarMediaVectorMaxValue()
        {
            LecturaNumerosVector nVector = new LecturaNumerosVector();

            int[] vector = int.MaxValue;
            int resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros MinValue
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorMinValue()
        {
            LecturaNumerosVector nVector = new LecturaNumerosVector();

            int vector = int.MinValue;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
