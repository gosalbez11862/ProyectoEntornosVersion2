// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 05-14-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="CNumeroMenor.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace NavajaSuiza.Ejercicio3
{
    /// <summary>
    /// Clase estatica para controlar el numero menor de un vector
    /// </summary>
    public static class NumeroMenor
    {
        /// <summary>
        /// Recorre el vector entero y devuelve
        /// el menor del vector.
        /// </summary>
        /// <param name="vector">el vector.</param>
        /// <returns>Devuelve el numero menor del vector</returns>
        public static int FMenorVector(int[] vector)
        {
            int menor,numero1, numero2, i, j;
            menor = 0;
            

            for (i = 0; i < vector.Length -1; i++)
            {
                numero1 = vector[i];

                for (j = i + 1; j < vector.Length; j++)
                {
                    numero2 = vector[j];

                    if (numero1 > numero2)
                    {
                        menor = numero2;
                    }
                    else
                    {
                        menor = numero1;
                    }
                }
            }
            return menor;
        }
    }
}
