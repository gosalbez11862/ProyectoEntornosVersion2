﻿namespace NavajaSuiza.Ejercicio13
{
    /// <summary>
    /// 	
    /// </summary>
    partial class CalcularBaseExponente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBase = new System.Windows.Forms.TextBox();
            this.TExponente = new System.Windows.Forms.TextBox();
            this.LResultado = new System.Windows.Forms.Label();
            this.LResultado1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCalcular
            // 
            this.BCalcular.Enabled = false;
            this.BCalcular.Location = new System.Drawing.Point(228, 20);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(100, 36);
            this.BCalcular.TabIndex = 0;
            this.BCalcular.Text = "Calcular";
            this.BCalcular.UseVisualStyleBackColor = true;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exponente: ";
            // 
            // TBase
            // 
            this.TBase.Location = new System.Drawing.Point(106, 23);
            this.TBase.MaxLength = 7;
            this.TBase.Name = "TBase";
            this.TBase.Size = new System.Drawing.Size(100, 29);
            this.TBase.TabIndex = 3;
            this.TBase.TextChanged += new System.EventHandler(this.TBase_TextChanged);
            // 
            // TExponente
            // 
            this.TExponente.Location = new System.Drawing.Point(157, 77);
            this.TExponente.MaxLength = 7;
            this.TExponente.Name = "TExponente";
            this.TExponente.Size = new System.Drawing.Size(100, 29);
            this.TExponente.TabIndex = 4;
            this.TExponente.TextChanged += new System.EventHandler(this.TBase_TextChanged);
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Location = new System.Drawing.Point(186, 138);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(0, 24);
            this.LResultado.TabIndex = 5;
            // 
            // LResultado1
            // 
            this.LResultado1.AutoSize = true;
            this.LResultado1.Location = new System.Drawing.Point(38, 138);
            this.LResultado1.Name = "LResultado1";
            this.LResultado1.Size = new System.Drawing.Size(139, 24);
            this.LResultado1.TabIndex = 6;
            this.LResultado1.Text = "El resultado es:";
            // 
            // CalcularBaseExponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 182);
            this.Controls.Add(this.LResultado1);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.TExponente);
            this.Controls.Add(this.TBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcularBaseExponente";
            this.Text = "Ejercicio 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBase;
        private System.Windows.Forms.TextBox TExponente;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Label LResultado1;
    }
}