namespace Ejercicio3
{
    partial class Tragaperra
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.jugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.saldo = new System.Windows.Forms.Label();
            this.credito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(80, 70);
            this.num1.Name = "num1";
            this.num1.ReadOnly = true;
            this.num1.Size = new System.Drawing.Size(40, 20);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(254, 70);
            this.num3.Name = "num3";
            this.num3.ReadOnly = true;
            this.num3.Size = new System.Drawing.Size(40, 20);
            this.num3.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(168, 70);
            this.num2.Name = "num2";
            this.num2.ReadOnly = true;
            this.num2.Size = new System.Drawing.Size(40, 20);
            this.num2.TabIndex = 2;
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(130, 133);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(126, 38);
            this.jugar.TabIndex = 3;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.jugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crédito: ";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn2.Location = new System.Drawing.Point(358, 133);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 38);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Añadir 10€ de crédito";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(408, 77);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(0, 13);
            this.saldo.TabIndex = 6;
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Location = new System.Drawing.Point(407, 77);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(28, 13);
            this.credito.TabIndex = 7;
            this.credito.Text = " 50€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Premio: ";
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.Location = new System.Drawing.Point(197, 104);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(19, 13);
            this.premio.TabIndex = 9;
            this.premio.Text = "0€";
            // 
            // Tragaperra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.premio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.credito);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num1);
            this.Name = "Tragaperra";
            this.Text = "Tragaperra";
            this.Load += new System.EventHandler(this.Tragaperra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label credito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label premio;
    }
}

