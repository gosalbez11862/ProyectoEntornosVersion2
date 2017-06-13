using System;
using NavajaSuiza.Ejercicio13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebaBaseExponente
    {
     /// <summary>
     /// Ejercicio 13.
     /// Controlar el resultado que da
     /// el valor de MaxValue
     /// </summary>

        [TestMethod]
        public void ControlarBaseMaxvalue()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double base1 = double.MaxValue;
            double Exponente1 = double.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

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
            double Exponente1 = double.MaxValue; ;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

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

            double base1 = double.MaxValue;
            double Exponente1 = double.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

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

            double base1 = double.MaxValue;
            double Exponente1 = double.MaxValue;
            double resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
