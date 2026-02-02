namespace Ejercicio4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btTraspasar = new System.Windows.Forms.Button();
            this.nElementos = new System.Windows.Forms.Label();
            this.elementosSelec = new System.Windows.Forms.Label();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.borrar1 = new System.Windows.Forms.RadioButton();
            this.borrar2 = new System.Windows.Forms.RadioButton();
            this.traspaso12 = new System.Windows.Forms.RadioButton();
            this.traspaso21 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(215, 29);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(104, 23);
            this.btAñadir.TabIndex = 1;
            this.btAñadir.Text = "Añadir";
            this.ayuda.SetToolTip(this.btAñadir, "Botón añadir");
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(215, 58);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(104, 23);
            this.btQuitar.TabIndex = 2;
            this.btQuitar.Text = "Quitar";
            this.ayuda.SetToolTip(this.btQuitar, "Botón eliminar elementos");
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btTraspasar
            // 
            this.btTraspasar.Location = new System.Drawing.Point(215, 87);
            this.btTraspasar.Name = "btTraspasar";
            this.btTraspasar.Size = new System.Drawing.Size(104, 23);
            this.btTraspasar.TabIndex = 3;
            this.btTraspasar.Text = "Traspasar";
            this.ayuda.SetToolTip(this.btTraspasar, "Botón trapasar elementos entre listas");
            this.btTraspasar.UseVisualStyleBackColor = true;
            this.btTraspasar.Click += new System.EventHandler(this.btTraspasar_Click);
            // 
            // nElementos
            // 
            this.nElementos.AutoSize = true;
            this.nElementos.Location = new System.Drawing.Point(362, 126);
            this.nElementos.Name = "nElementos";
            this.nElementos.Size = new System.Drawing.Size(85, 13);
            this.nElementos.TabIndex = 4;
            this.nElementos.Text = "Nº de elementos";
            // 
            // elementosSelec
            // 
            this.elementosSelec.AutoSize = true;
            this.elementosSelec.Location = new System.Drawing.Point(346, 151);
            this.elementosSelec.Name = "elementosSelec";
            this.elementosSelec.Size = new System.Drawing.Size(127, 13);
            this.elementosSelec.TabIndex = 5;
            this.elementosSelec.Text = "Elementos seleccionados";
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(349, 29);
            this.lista1.Name = "lista1";
            this.lista1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lista1.Size = new System.Drawing.Size(109, 82);
            this.lista1.TabIndex = 6;
            this.ayuda.SetToolTip(this.lista1, "Lista 1 (selección múltiple)");
            this.lista1.SelectedIndexChanged += new System.EventHandler(this.lista1_SelectedIndexChanged);
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(480, 28);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(109, 82);
            this.lista2.TabIndex = 7;
            // 
            // borrar1
            // 
            this.borrar1.AutoSize = true;
            this.borrar1.Location = new System.Drawing.Point(25, 17);
            this.borrar1.Name = "borrar1";
            this.borrar1.Size = new System.Drawing.Size(53, 17);
            this.borrar1.TabIndex = 8;
            this.borrar1.TabStop = true;
            this.borrar1.Text = "Lista1";
            this.borrar1.UseVisualStyleBackColor = true;
            this.borrar1.CheckedChanged += new System.EventHandler(this.borrar1_CheckedChanged);
            // 
            // borrar2
            // 
            this.borrar2.AutoSize = true;
            this.borrar2.Location = new System.Drawing.Point(25, 34);
            this.borrar2.Name = "borrar2";
            this.borrar2.Size = new System.Drawing.Size(53, 17);
            this.borrar2.TabIndex = 9;
            this.borrar2.TabStop = true;
            this.borrar2.Text = "Lista2";
            this.borrar2.UseVisualStyleBackColor = true;
            this.borrar2.CheckedChanged += new System.EventHandler(this.borrar2_CheckedChanged);
            // 
            // traspaso12
            // 
            this.traspaso12.AutoSize = true;
            this.traspaso12.Location = new System.Drawing.Point(25, 16);
            this.traspaso12.Name = "traspaso12";
            this.traspaso12.Size = new System.Drawing.Size(74, 17);
            this.traspaso12.TabIndex = 10;
            this.traspaso12.TabStop = true;
            this.traspaso12.Text = "Lista 1 a 2";
            this.traspaso12.UseVisualStyleBackColor = true;
            this.traspaso12.CheckedChanged += new System.EventHandler(this.traspaso12_CheckedChanged);
            // 
            // traspaso21
            // 
            this.traspaso21.AutoSize = true;
            this.traspaso21.Location = new System.Drawing.Point(25, 35);
            this.traspaso21.Name = "traspaso21";
            this.traspaso21.Size = new System.Drawing.Size(74, 17);
            this.traspaso21.TabIndex = 11;
            this.traspaso21.TabStop = true;
            this.traspaso21.Text = "Lista 2 a 1";
            this.traspaso21.UseVisualStyleBackColor = true;
            this.traspaso21.CheckedChanged += new System.EventHandler(this.traspaso21_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrar1);
            this.groupBox1.Controls.Add(this.borrar2);
            this.groupBox1.Location = new System.Drawing.Point(630, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 51);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir lista a borrar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.traspaso12);
            this.groupBox2.Controls.Add(this.traspaso21);
            this.groupBox2.Location = new System.Drawing.Point(630, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elegir lista para traspaso";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.elementosSelec);
            this.Controls.Add(this.nElementos);
            this.Controls.Add(this.btTraspasar);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btTraspasar;
        private System.Windows.Forms.Label nElementos;
        private System.Windows.Forms.Label elementosSelec;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.RadioButton borrar1;
        private System.Windows.Forms.RadioButton borrar2;
        private System.Windows.Forms.RadioButton traspaso12;
        private System.Windows.Forms.RadioButton traspaso21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ayuda;
    }
}

