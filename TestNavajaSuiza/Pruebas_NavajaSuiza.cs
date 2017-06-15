using NavajaSuiza.Ejercicio2;
using NavajaSuiza.Ejercicio3;
using NavajaSuiza.Ejercicio4;
using NavajaSuiza.Ejercicio13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class PruebasConversorMoneda
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

            Assert.AreEqual(resultadoEsperado, resultadObtenido, 0.001);
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
            double resultadoEsperado = 0.036;
            double resultadoObtenido = 0;

            //Acción a Probar
            resultadoObtenido = CPtsEuros.FConversoreu(cantidadEuros);

            //Afirmación de la Prueba
            Assert.AreEqual(resultadoEsperado, resultadoObtenido, 0.001);
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
            double resultadoEsperado = 60.097;

            var resultadObtenido = CPtsEuros.FConversoreu(euros);

            Assert.AreEqual(resultadoEsperado, resultadObtenido, 0.001);
        }        
    }

    [TestClass]
    public class PruebaBaseExponete
    {
        /// <summary>
        /// Ejercicio 13.
        /// Controlar el resultado que de un numero
        /// </summary>

        [TestMethod]
        public void ControlarBaseExponente()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double base1 = 25;
            double Exponente1 = 2;
            double resultadObtenido;
            double resultadoEsperado = 625;

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
            double Exponente1 = 0;
            double resultadObtenido;
            double resultadoEsperado = 1;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 13.
        /// Comprobar si soporta la base y el exponente que sean negativos
        /// </summary>

        [TestMethod]
        public void ControlarBaseExponenteNegativos()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double base1 = -25;
            double Exponente1 = -5;
            double resultadObtenido;
            double resultadoEsperado = 1;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 13.
        /// Comprobar si soporta la base el numero 1
        /// </summary>

        [TestMethod]
        public void ControlarBase()
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double base1 = 1;
            double Exponente1 = 12;
            double resultadObtenido;
            double resultadoEsperado = 1;

            resultadObtenido = baseExponente.Potencia(base1, Exponente1);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }

    [TestClass]
    public class PruebaLecturaVector
    {
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector de numeros repetidos
        /// </summary>

        [TestMethod]
        public void ControlarMediaVector()
        {
            CLecturaVector ClassVector = new CLecturaVector();
            int i;

            int[] vector = new int[10];

            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = 10;
            }

            int resultadObtenido;
            int resultadoEsperado = 10;

            resultadObtenido = ClassVector.FMediaVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros positivos
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorNumerosPositivos()
        {
            CLecturaVector ClassVector = new CLecturaVector();

            int[] vector = new int[10] { 1, 2, 3, 4, 5, 1, 1, 0, 2, 1 };

            int resultadObtenido;
            int resultadoEsperado = 2;

            resultadObtenido = ClassVector.FMediaVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 2.
        /// Comprobar si soporta el vector numeros negativos
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorNumerosNegativos()
        {
            CLecturaVector ClassVector = new CLecturaVector();

            int[] vector = new int[10] { -1, -2, -3, -4, -5, -1, -1, -20, -2, -1 };

            int resultadObtenido;
            int resultadoEsperado = -4;

            resultadObtenido = ClassVector.FMediaVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }

    [TestClass]
    public class PruebaNumeroMenorVector
    {
        /// <summary>
        /// Ejercicio 3.
        /// Comprobar el menor del mismo numero
        /// </summary>

        [TestMethod]
        public void ControlarMediaVector()
        {
            int i;

            int[] vector = new int[10];

            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = 10;
            }

            int resultadObtenido;
            int resultadoEsperado = 10;

            resultadObtenido = NumeroMenor.FMenorVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
        /// <summary>
        /// Ejercicio 3.
        /// Comprobar el menor de numeros positivos
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorNumerosPositivos()
        {
            CLecturaVector ClassVector = new CLecturaVector();

            int[] vector = new int[10] { 1, 2, 3, 4, 5, 1, 1, 0, 2, 1 };

            int resultadObtenido;
            int resultadoEsperado = 1;

            resultadObtenido = NumeroMenor.FMenorVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }

        /// <summary>
        /// Ejercicio 2.
        /// Comprobar el menor de numeros negativos
        /// </summary>
        [TestMethod]
        public void ControlarMediaVectorNumerosNegativos()
        {
            CLecturaVector ClassVector = new CLecturaVector();

            int[] vector = new int[10] { -1, -2, -3, -4, -5, -1, -1, -20, -2, -1 };

            int resultadObtenido;
            int resultadoEsperado = -2;

            resultadObtenido = NumeroMenor.FMenorVector(vector);

            Assert.AreEqual(resultadoEsperado, resultadObtenido);
        }
    }
}
