namespace GUIA07
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBiblioteca = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCarnetUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBiblioteca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBiblioteca);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBiblioteca
            // 
            this.tabBiblioteca.Controls.Add(this.btnAgregarUsuario);
            this.tabBiblioteca.Controls.Add(this.txtCarnetUsuario);
            this.tabBiblioteca.Controls.Add(this.txtNombreUsuario);
            this.tabBiblioteca.Controls.Add(this.lblCarnet);
            this.tabBiblioteca.Controls.Add(this.lblNombreUsuario);
            this.tabBiblioteca.Controls.Add(this.LblUsuario);
            this.tabBiblioteca.Location = new System.Drawing.Point(4, 29);
            this.tabBiblioteca.Name = "tabBiblioteca";
            this.tabBiblioteca.Padding = new System.Windows.Forms.Padding(3);
            this.tabBiblioteca.Size = new System.Drawing.Size(896, 538);
            this.tabBiblioteca.TabIndex = 0;
            this.tabBiblioteca.Text = "Usuarios";
            this.tabBiblioteca.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prestamos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(17, 16);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(318, 37);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Registro de Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(17, 64);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(212, 29);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Completo";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(17, 108);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(84, 29);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(49, 167);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtCarnetUsuario
            // 
            this.txtCarnetUsuario.Location = new System.Drawing.Point(49, 213);
            this.txtCarnetUsuario.Name = "txtCarnetUsuario";
            this.txtCarnetUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtCarnetUsuario.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(62, 261);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(187, 38);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabBiblioteca.ResumeLayout(false);
            this.tabBiblioteca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBiblioteca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtCarnetUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
    }
}

