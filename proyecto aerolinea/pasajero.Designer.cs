namespace proyecto_aerolinea
{
    partial class pasajero
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
            this.components = new System.ComponentModel.Container();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dtpFecna = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.consultarbtn = new System.Windows.Forms.Button();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.dtpFecna);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eliminarbtn);
            this.panel1.Controls.Add(this.modificarbtn);
            this.panel1.Controls.Add(this.consultarbtn);
            this.panel1.Controls.Add(this.ingresarbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 511);
            this.panel1.TabIndex = 0;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(67, 305);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(229, 21);
            this.cmbGenero.TabIndex = 46;
            this.cmbGenero.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // dtpFecna
            // 
            this.dtpFecna.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecna.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecna.Location = new System.Drawing.Point(66, 225);
            this.dtpFecna.Name = "dtpFecna";
            this.dtpFecna.Size = new System.Drawing.Size(230, 23);
            this.dtpFecna.TabIndex = 45;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(66, 442);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 23);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(63, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(66, 372);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 23);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(63, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(63, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(63, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(66, 155);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 23);
            this.txtApellido.TabIndex = 38;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(63, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(66, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 23);
            this.txtNombre.TabIndex = 36;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre";
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.eliminarbtn.Location = new System.Drawing.Point(506, 257);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(116, 38);
            this.eliminarbtn.TabIndex = 31;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // modificarbtn
            // 
            this.modificarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.modificarbtn.Location = new System.Drawing.Point(506, 208);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(116, 38);
            this.modificarbtn.TabIndex = 32;
            this.modificarbtn.Text = "Modificar";
            this.modificarbtn.UseVisualStyleBackColor = true;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click_1);
            // 
            // consultarbtn
            // 
            this.consultarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarbtn.Location = new System.Drawing.Point(506, 158);
            this.consultarbtn.Name = "consultarbtn";
            this.consultarbtn.Size = new System.Drawing.Size(116, 38);
            this.consultarbtn.TabIndex = 33;
            this.consultarbtn.Text = "Consultar";
            this.consultarbtn.UseVisualStyleBackColor = true;
            this.consultarbtn.Click += new System.EventHandler(this.consultarbtn_Click_1);
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ingresarbtn.Location = new System.Drawing.Point(506, 109);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(116, 38);
            this.ingresarbtn.TabIndex = 34;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            this.ingresarbtn.Click += new System.EventHandler(this.ingresarbtn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(430, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "label7";
            // 
            // pasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pasajero";
            this.Text = "pasajero";
            this.Load += new System.EventHandler(this.Pasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DateTimePicker dtpFecna;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button consultarbtn;
        private System.Windows.Forms.Button ingresarbtn;
        private System.Windows.Forms.Label label7;
    }
}