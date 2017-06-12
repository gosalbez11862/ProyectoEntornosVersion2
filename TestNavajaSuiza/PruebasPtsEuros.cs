﻿using NavajaSuiza.Ejercicio4;

using NavajaSuiza.Ejercicio2;
using NavajaSuiza.Ejercicio3;
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
            bool resultadObtenido;
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
            bool resultadObtenido;
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
            bool resultadObtenido;
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
            bool resultadObtenido;
            bool resultadoEsperado = true;

            resultadObtenido = conversor.ComprobarEuros(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        //==============================================//

        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros Maxvalue
        /// </summary>
        
        [TestMethod]
        public void ControlarMediaVectorMaxValue()
        {
            LecturaNumerosVector nVector = new LecturaNumerosVector();

            int vector = int.MaxValue;
            bool resultadObtenido;
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
            bool resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        //===================================================//

        /// <summary>
        /// Ejercicio 3.
        /// Comprobar si soporta el vector numeros MinValue
        /// </summary>
        [TestMethod]
        public void ControlarMenorVectorMaxValue()
        {
            NumeroVectorMenor nmVector = new NumeroVectorMenor();

            int vector = int.MaxValue;
            bool resultadObtenido;
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
            bool resultadObtenido;
            bool resultadoEsperado = false;

            resultadObtenido = nmVector.FLeerVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}