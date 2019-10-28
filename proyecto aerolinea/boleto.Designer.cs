namespace proyecto_aerolinea
{
    partial class boleto
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
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.consultarbtn = new System.Windows.Forms.Button();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.eliminarbtn.Location = new System.Drawing.Point(535, 248);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(116, 38);
            this.eliminarbtn.TabIndex = 1;
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
            this.modificarbtn.Location = new System.Drawing.Point(535, 199);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(116, 38);
            this.modificarbtn.TabIndex = 2;
            this.modificarbtn.Text = "Modificar";
            this.modificarbtn.UseVisualStyleBackColor = true;
            // 
            // consultarbtn
            // 
            this.consultarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarbtn.Location = new System.Drawing.Point(535, 149);
            this.consultarbtn.Name = "consultarbtn";
            this.consultarbtn.Size = new System.Drawing.Size(116, 38);
            this.consultarbtn.TabIndex = 3;
            this.consultarbtn.Text = "Consultar";
            this.consultarbtn.UseVisualStyleBackColor = true;
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ingresarbtn.Location = new System.Drawing.Point(535, 100);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(116, 38);
            this.ingresarbtn.TabIndex = 4;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            // 
            // boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.consultarbtn);
            this.Controls.Add(this.ingresarbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "boleto";
            this.Text = "boleto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button consultarbtn;
        private System.Windows.Forms.Button ingresarbtn;
    }
}