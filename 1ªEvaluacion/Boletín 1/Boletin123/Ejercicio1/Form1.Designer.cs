namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.texto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(208, 52);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(13, 13);
            this.resultado.TabIndex = 1;
            this.resultado.Text = "=";
            this.resultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(90, 75);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(73, 39);
            this.suma.TabIndex = 2;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto1
            // 
            this.texto1.Location = new System.Drawing.Point(57, 49);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(60, 20);
            this.texto1.TabIndex = 3;
            this.texto1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texto2
            // 
            this.texto2.Location = new System.Drawing.Point(142, 49);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(60, 20);
            this.texto2.TabIndex = 4;
            this.texto2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox texto1;
        private System.Windows.Forms.TextBox texto2;
    }
}

