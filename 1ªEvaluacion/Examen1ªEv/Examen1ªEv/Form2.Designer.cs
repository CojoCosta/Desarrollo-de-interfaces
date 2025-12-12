namespace Examen1ªEv
{
    partial class Form2
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNoGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(102, 28);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre Receta";
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(111, 75);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labDescripcion.TabIndex = 1;
            this.labDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(52, 91);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 223);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(122, 341);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(42, 13);
            this.lbTiempo.TabIndex = 4;
            this.lbTiempo.Text = "Tiempo";
            // 
            // cbTiempo
            // 
            this.cbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiempo.IntegralHeight = false;
            this.cbTiempo.Location = new System.Drawing.Point(52, 357);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(178, 21);
            this.cbTiempo.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGuardar.Location = new System.Drawing.Point(52, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNoGuardar
            // 
            this.btnNoGuardar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNoGuardar.Location = new System.Drawing.Point(155, 445);
            this.btnNoGuardar.Name = "btnNoGuardar";
            this.btnNoGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnNoGuardar.TabIndex = 4;
            this.btnNoGuardar.TabStop = false;
            this.btnNoGuardar.Text = "No guardar";
            this.btnNoGuardar.UseVisualStyleBackColor = true;
            this.btnNoGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 490);
            this.Controls.Add(this.btnNoGuardar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form2";
            this.Text = "Nueva Receta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label lbTiempo;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNoGuardar;
        public System.Windows.Forms.TextBox txtNombre;
    }
}