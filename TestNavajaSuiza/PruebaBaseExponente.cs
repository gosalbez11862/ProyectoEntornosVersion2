using System;
using NavajaSuiza.Ejercicio13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaBaseExponente()
        {
            /// <summary>
            /// Ejercicio 13.
            /// Controlar el resultado que da
            /// el valor de MaxValue
           /// </summary>

        [TestMethod]
        public void ControlarBaseMaxvalue()
        {
            CalcularBaseExponente baseExponente = new CalcularBaseExponente();

            double base1 = double.MaxValue;
            bool resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 13.
        /// Comprobar si soporta los numeros negativos
        /// </summary>

        [TestMethod]
        public void ControlarBaseNegativo()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double base1 = -10;
            double base2 = 1;
            bool resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1, base2);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 13.
        /// Comprobar si soporta el MaxValue
        /// </summary>

        [TestMethod]
        public void ControlarExponenteMaxValue()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double exponente = double.MaxValue;
            bool resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(exponente);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 13.
        /// Comprobar si soporta los numeros negativos
        /// </summary>

        [TestMethod]
        public void ControlarExponenteNegativo()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double exponente = double.MaxValue;
            bool resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(exponente);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
        
    }
}
