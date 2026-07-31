namespace GUIA03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNFACTO = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNFACTO2 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNFACTO
            // 
            this.BTNFACTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNFACTO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNFACTO.BackgroundImage")));
            this.BTNFACTO.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFACTO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNFACTO.Location = new System.Drawing.Point(53, 50);
            this.BTNFACTO.Name = "BTNFACTO";
            this.BTNFACTO.Size = new System.Drawing.Size(144, 55);
            this.BTNFACTO.TabIndex = 0;
            this.BTNFACTO.Text = "FACTO";
            this.BTNFACTO.UseVisualStyleBackColor = false;
            this.BTNFACTO.Click += new System.EventHandler(this.BTNFACTO_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Red;
            this.BTNSALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.BackgroundImage")));
            this.BTNSALIR.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSALIR.Location = new System.Drawing.Point(53, 163);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(144, 55);
            this.BTNSALIR.TabIndex = 1;
            this.BTNSALIR.Text = "Salir";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNFACTO2
            // 
            this.BTNFACTO2.BackColor = System.Drawing.Color.White;
            this.BTNFACTO2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFACTO2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNFACTO2.Location = new System.Drawing.Point(257, 50);
            this.BTNFACTO2.Name = "BTNFACTO2";
            this.BTNFACTO2.Size = new System.Drawing.Size(144, 55);
            this.BTNFACTO2.TabIndex = 2;
            this.BTNFACTO2.Text = "FACTO2";
            this.BTNFACTO2.UseVisualStyleBackColor = false;
            this.BTNFACTO2.Click += new System.EventHandler(this.BTNFACTO2_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.Black;
            this.BTN4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN4.Location = new System.Drawing.Point(466, 50);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(144, 55);
            this.BTN4.TabIndex = 3;
            this.BTN4.Text = "FACTO3";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 564);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTNFACTO2);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNFACTO);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNFACTO;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Button BTNFACTO2;
        private System.Windows.Forms.Button BTN4;
    }
}

