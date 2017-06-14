﻿// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 04-19-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="ConvertirPtsEuros.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace NavajaSuiza.Ejercicio4
{
    /// <summary>
    /// programa para hacer el cambio de moneda de euros a pesetas y vicebersa
    /// </summary>
    public partial class ConvertirPtsEuros : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la <see cref="ConvertirPtsEuros" /> clase.
        /// </summary>
        public ConvertirPtsEuros()
        {
            InitializeComponent();
        }
        /// <summary>
        /// comprueba si el numero introducido es correcto
        /// y si lo es lo manda a la funcion <see cref="CPtsEuros.FConversorpta"/>
        /// para hacer la conversion
        /// </summary>
        public void ComprobarPesetas()
        {
            double euro, resultado;
            bool moneda = false;

            moneda = double.TryParse(TEuros.Text, out euro);

            if (moneda == true)
            {
                if (euro > 0)
                {
                    resultado = CPtsEuros.FConversorpta(euro);
                    TPesetas.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Debes introducir un numero positivo");
                    TPesetas.Text = "";
                    TEuros.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Introducir un número en la casilla de Pesetas.");
                TPesetas.Text = "";
                TEuros.Text = "";
            }
            TEuros.Text = "";
        }

        /// <summary>
        /// comprueba si el numero introducido es correcto
        /// y si lo es lo manda a la funcion <see cref="CPtsEuros.FConversoreu"/>
        /// para hacer la conversion
        /// </summary>
        public void ComprobarEuros()
        {
            double pta,resultado;
            bool moneda = false;

            moneda = double.TryParse(TPesetas.Text, out pta);

            if (moneda == true)
            {
                if (pta > 0)
                {
                    resultado = CPtsEuros.FConversoreu(pta);
                    TEuros.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Debes introducir un numero positivo o superior a 0");
                    TPesetas.Text = "";
                    TEuros.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Introducir un número en la casilla de Euros.");
                TPesetas.Text = "";
                TEuros.Text = "";
            }
            TPesetas.Text = "";
        }

        /// <summary>
        /// Boton para covertir los euros a pesetas.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> Ejemplo que contiene los datos del evento.</param>
        private void BPesetas_Click(object sender, EventArgs e)
        {
            ComprobarPesetas();   
        }

        /// <summary>
        /// Boton para covertir los pesetas a euros.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> Ejemplo que contiene los datos del evento.</param>
        private void BEuros_Click(object sender, EventArgs e)
        {
            ComprobarEuros();
        }

        /// <summary>
        /// Evento para comprobar los TextBox y que solo se 
        /// itroduzcas numeros doubles y no letras ni caracteres extraños
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> Ejemplo que contiene los datos del evento.</param>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            double euros,pesetas;

            if (double.TryParse(TEuros.Text, out euros) || double.TryParse(TPesetas.Text, out pesetas))
            {
                BPesetas.Enabled = true;
                BEuros.Enabled = true;
            }
            else
            {
                BPesetas.Enabled = false;
                BEuros.Enabled = false;
            }
        }
    }
}
