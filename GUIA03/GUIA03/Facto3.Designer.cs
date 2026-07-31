namespace GUIA03
{
    partial class Facto3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facto3));
            this.LBL1 = new System.Windows.Forms.Label();
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.LBL2 = new System.Windows.Forms.Label();
            this.TXTB2 = new System.Windows.Forms.TextBox();
            this.BTNCALCUL = new System.Windows.Forms.Button();
            this.BTNLIMP = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(109, 57);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(124, 34);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Numero:";
            // 
            // TXTB1
            // 
            this.TXTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB1.Location = new System.Drawing.Point(115, 118);
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(558, 35);
            this.TXTB1.TabIndex = 1;
            this.TXTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB1_KeyPress);
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(109, 179);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(124, 34);
            this.LBL2.TabIndex = 2;
            this.LBL2.Text = "Al revés:";
            // 
            // TXTB2
            // 
            this.TXTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB2.Location = new System.Drawing.Point(115, 241);
            this.TXTB2.Name = "TXTB2";
            this.TXTB2.Size = new System.Drawing.Size(558, 35);
            this.TXTB2.TabIndex = 3;
            // 
            // BTNCALCUL
            // 
            this.BTNCALCUL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCALCUL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNCALCUL.Location = new System.Drawing.Point(115, 342);
            this.BTNCALCUL.Name = "BTNCALCUL";
            this.BTNCALCUL.Size = new System.Drawing.Size(118, 51);
            this.BTNCALCUL.TabIndex = 4;
            this.BTNCALCUL.Text = "Calcular";
            this.BTNCALCUL.UseVisualStyleBackColor = false;
            this.BTNCALCUL.Click += new System.EventHandler(this.BTNCALCUL_Click);
            // 
            // BTNLIMP
            // 
            this.BTNLIMP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNLIMP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNLIMP.Location = new System.Drawing.Point(555, 342);
            this.BTNLIMP.Name = "BTNLIMP";
            this.BTNLIMP.Size = new System.Drawing.Size(118, 51);
            this.BTNLIMP.TabIndex = 5;
            this.BTNLIMP.Text = "Limpiar";
            this.BTNLIMP.UseVisualStyleBackColor = false;
            this.BTNLIMP.Click += new System.EventHandler(this.BTNLIMP_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSALIR.Location = new System.Drawing.Point(340, 434);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(118, 51);
            this.BTNSALIR.TabIndex = 6;
            this.BTNSALIR.Text = "Salir";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // Facto3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNLIMP);
            this.Controls.Add(this.BTNCALCUL);
            this.Controls.Add(this.TXTB2);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.LBL1);
            this.DoubleBuffered = true;
            this.Name = "Facto3";
            this.Text = "Facto3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.TextBox TXTB2;
        private System.Windows.Forms.Button BTNCALCUL;
        private System.Windows.Forms.Button BTNLIMP;
        private System.Windows.Forms.Button BTNSALIR;
    }
}