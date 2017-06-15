using NavajaSuiza.Ejercicio2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebaLecturaVector
    {
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros Maxvalue
        /// </summary>

        [TestMethod]
        public void ControlarMediaVectorMaxValue()
        {
           /* LecturaNumerosVector nVector = new LecturaNumerosVector();

            int vector1 = int.MaxValue;
            int resultadObtenido;
            bool resultadoEsperado = false;
        
            resultadObtenido = nVector.FLeerVector(vector1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);*/
        }
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros MinValue
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorMinValue()
        {
            /*LecturaNumerosVector nVector = new LecturaNumerosVector();

            int vector1 = int.MinValue;
            double resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nVector.FLeerVector(vector1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);*/
        }
    }
}
