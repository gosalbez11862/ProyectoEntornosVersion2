﻿// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 05-14-2017
//
// Last Modified By : 
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="CLecturaVector.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace NavajaSuiza.Ejercicio2
{
    /// <summary>
    /// calcula la media del vector
    /// </summary>
    public class LecturaVector
    {
        /// <summary>
        /// Constante que da el tope al vector
        /// </summary>
        const int KTam = 10;

        /// <summary>
        /// Recorre el vector entero y devuelve
        /// la media.
        /// </summary>
        /// <param name="vector">el vector.</param>
        /// <returns>Devuelve la media del vector entero</returns>
        public int FMediaVector(int[] vector)
        {
            int media, i;
            media = 0;

            for (i = 0; i < vector.Length; i++)
            {
                media = media + vector[i];
            }
            media = media / KTam;

            return media;
        }
    }
}
