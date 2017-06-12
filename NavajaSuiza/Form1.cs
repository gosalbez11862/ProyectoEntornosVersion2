﻿// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 09-04-2017
//
// Last Modified By : Carlos
// Last Modified On : 09-05-2017
// ***********************************************************************
// <copyright file="NavajaSuiza.cs">
// </copyright>
// <summary>Proyecto de Entornos</summary>
// ***********************************************************************
using NavajaSuiza.Ejercicio13;
using NavajaSuiza.Ejercicio4;
using NavajaSuiza.Ejercicio2;
using NavajaSuiza.Ejercicio3;
using System;
using System.Windows.Forms;

namespace NavajaSuiza
{
    /// <summary>
    /// <para>Union de 4 ejercicios para conformar un proyecto de entornos</para>
    /// <para>Los distintos ejercicios son:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Tema 4 - Ejercicio 4 </description>
    ///         <description> Conversor de Moneda, pasar de Pesetas
    ///         a euros y al reves.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tema 4 - Ejercicio 13 </description>
    ///         <description> calcular la base dada con el 
    ///         exponente dado.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tema 5 - Ejercicio 2 </description>
    ///         <description> Lectura de 10 numeros en un vector
    ///         y nos devuelve la media de todo el vector.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tema 5 - Ejercicio 3 </description>
    ///         <description> Lectura de 10 numeros en un vector
    ///         y nos devuelve el numero menor de todos ellos.</description>
    ///     </item>
    /// </list>
    /// </para>
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Inicializa una nueva instancia de la <see cref="Form1"/> clase.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instanciamos el form <see cref="ConvertirPtsEuros"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4.ConvertirPtsEuros oFormulario1 = new Ejercicio4.ConvertirPtsEuros();
            oFormulario1.ShowDialog();
        }

        /// <summary>
        /// Instanciamos el form <see cref="CalcularBaseExponente"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio13_Click(object sender, EventArgs e)
        {
            Ejercicio13.CalcularBaseExponente oFormulario2 = new Ejercicio13.CalcularBaseExponente();
            oFormulario2.ShowDialog();

        }

        /// <summary>
        /// Instanciamos el form <see cref="LecturaNumerosVector"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2.LecturaNumerosVector oFormulario3 = new Ejercicio2.LecturaNumerosVector();
            oFormulario3.ShowDialog();
        }

        /// <summary>
        /// Instanciamos el form <see cref="NumeroVectorMenor"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3.NumeroVectorMenor oFormulario4 = new Ejercicio3.NumeroVectorMenor();
            oFormulario4.ShowDialog();
        }
    }
}
