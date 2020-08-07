namespace EjemploSwitch
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbhombre = new System.Windows.Forms.RadioButton();
            this.rbmujer = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgempleado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26F);
            this.label1.Location = new System.Drawing.Point(220, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(70, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(458, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbhombre);
            this.groupBox1.Controls.Add(this.rbmujer);
            this.groupBox1.Location = new System.Drawing.Point(463, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género:";
            // 
            // rbhombre
            // 
            this.rbhombre.AutoSize = true;
            this.rbhombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbhombre.Location = new System.Drawing.Point(25, 35);
            this.rbhombre.Name = "rbhombre";
            this.rbhombre.Size = new System.Drawing.Size(84, 24);
            this.rbhombre.TabIndex = 0;
            this.rbhombre.TabStop = true;
            this.rbhombre.Text = "Hombre";
            this.rbhombre.UseVisualStyleBackColor = true;
            // 
            // rbmujer
            // 
            this.rbmujer.AutoSize = true;
            this.rbmujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbmujer.Location = new System.Drawing.Point(154, 35);
            this.rbmujer.Name = "rbmujer";
            this.rbmujer.Size = new System.Drawing.Size(66, 24);
            this.rbmujer.TabIndex = 1;
            this.rbmujer.TabStop = true;
            this.rbmujer.Text = "Mujer";
            this.rbmujer.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtnombre.Location = new System.Drawing.Point(172, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(263, 38);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtapellido.Location = new System.Drawing.Point(172, 161);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(263, 38);
            this.txtapellido.TabIndex = 6;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtedad.Location = new System.Drawing.Point(533, 104);
            this.txtedad.MaxLength = 3;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(87, 38);
            this.txtedad.TabIndex = 7;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(172, 216);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(263, 55);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgempleado
            // 
            this.dgempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Genero});
            this.dgempleado.Location = new System.Drawing.Point(75, 303);
            this.dgempleado.Name = "dgempleado";
            this.dgempleado.Size = new System.Drawing.Size(649, 150);
            this.dgempleado.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 200;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.dgempleado);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmujer;
        private System.Windows.Forms.RadioButton rbhombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
    }
}

