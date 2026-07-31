namespace GUIA03
{
    partial class Facto2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facto2));
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.TXTB2 = new System.Windows.Forms.TextBox();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.RD2 = new System.Windows.Forms.RadioButton();
            this.RD1 = new System.Windows.Forms.RadioButton();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.LBL4 = new System.Windows.Forms.Label();
            this.TXTB3 = new System.Windows.Forms.TextBox();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(259, 9);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(416, 34);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Encriptamiento por código César";
            this.LBL1.Click += new System.EventHandler(this.LBL1_Click);
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(7, 78);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(448, 29);
            this.LBL2.TabIndex = 1;
            this.LBL2.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL3.Location = new System.Drawing.Point(289, 120);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(354, 29);
            this.LBL3.TabIndex = 2;
            this.LBL3.Text = "Llave (Digite un número entero)";
            // 
            // TXTB1
            // 
            this.TXTB1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB1.Location = new System.Drawing.Point(649, 123);
            this.TXTB1.Multiline = true;
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(196, 26);
            this.TXTB1.TabIndex = 3;
            this.TXTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB1_KeyPress);
            // 
            // TXTB2
            // 
            this.TXTB2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB2.Location = new System.Drawing.Point(47, 159);
            this.TXTB2.Multiline = true;
            this.TXTB2.Name = "TXTB2";
            this.TXTB2.Size = new System.Drawing.Size(806, 152);
            this.TXTB2.TabIndex = 4;
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.RD2);
            this.GB1.Controls.Add(this.RD1);
            this.GB1.Location = new System.Drawing.Point(47, 368);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(385, 85);
            this.GB1.TabIndex = 5;
            this.GB1.TabStop = false;
            this.GB1.Text = "Seleccione una opción";
            // 
            // RD2
            // 
            this.RD2.AutoSize = true;
            this.RD2.Location = new System.Drawing.Point(218, 36);
            this.RD2.Name = "RD2";
            this.RD2.Size = new System.Drawing.Size(125, 24);
            this.RD2.TabIndex = 1;
            this.RD2.Text = "Desencriptar";
            this.RD2.UseVisualStyleBackColor = true;
            this.RD2.CheckedChanged += new System.EventHandler(this.RD2_CheckedChanged);
            // 
            // RD1
            // 
            this.RD1.AutoSize = true;
            this.RD1.Checked = true;
            this.RD1.Location = new System.Drawing.Point(30, 36);
            this.RD1.Name = "RD1";
            this.RD1.Size = new System.Drawing.Size(102, 24);
            this.RD1.TabIndex = 0;
            this.RD1.TabStop = true;
            this.RD1.Text = "Encriptar ";
            this.RD1.UseVisualStyleBackColor = true;
            this.RD1.CheckedChanged += new System.EventHandler(this.RD1_CheckedChanged);
            // 
            // BTN1
            // 
            this.BTN1.AutoSize = true;
            this.BTN1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(466, 378);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(137, 50);
            this.BTN1.TabIndex = 6;
            this.BTN1.Text = "&Encriptar";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTN2
            // 
            this.BTN2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(649, 378);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(137, 50);
            this.BTN2.TabIndex = 7;
            this.BTN2.Text = "&Limpiar";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // LBL4
            // 
            this.LBL4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL4.Location = new System.Drawing.Point(41, 489);
            this.LBL4.Name = "LBL4";
            this.LBL4.Size = new System.Drawing.Size(139, 43);
            this.LBL4.TabIndex = 9;
            // 
            // TXTB3
            // 
            this.TXTB3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB3.Location = new System.Drawing.Point(39, 535);
            this.TXTB3.Multiline = true;
            this.TXTB3.Name = "TXTB3";
            this.TXTB3.Size = new System.Drawing.Size(806, 152);
            this.TXTB3.TabIndex = 10;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(553, 434);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(137, 50);
            this.BTNSALIR.TabIndex = 11;
            this.BTNSALIR.Text = "Salir";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // Facto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 694);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.TXTB3);
            this.Controls.Add(this.LBL4);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.TXTB2);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facto2";
            this.Text = "Encriptador/Desencriptador de Código de";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.TextBox TXTB2;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.RadioButton RD2;
        private System.Windows.Forms.RadioButton RD1;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Label LBL4;
        private System.Windows.Forms.TextBox TXTB3;
        private System.Windows.Forms.Button BTNSALIR;
    }
}