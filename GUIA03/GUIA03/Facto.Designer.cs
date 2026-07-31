namespace GUIA03
{
    partial class Facto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facto));
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.TXTB2 = new System.Windows.Forms.TextBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(122, 174);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(224, 38);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Número:";
            this.LBL1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL2
            // 
            this.LBL2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(496, 178);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(224, 38);
            this.LBL2.TabIndex = 1;
            this.LBL2.Text = "Factorial:";
            this.LBL2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTB1
            // 
            this.TXTB1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB1.Location = new System.Drawing.Point(128, 278);
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(218, 46);
            this.TXTB1.TabIndex = 2;
            this.TXTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB1_KeyPress);
            // 
            // TXTB2
            // 
            this.TXTB2.Enabled = false;
            this.TXTB2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB2.Location = new System.Drawing.Point(502, 282);
            this.TXTB2.Name = "TXTB2";
            this.TXTB2.Size = new System.Drawing.Size(218, 41);
            this.TXTB2.TabIndex = 3;
            // 
            // BTN1
            // 
            this.BTN1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(165, 399);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(145, 67);
            this.BTN1.TabIndex = 4;
            this.BTN1.Text = "&Calcular";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTN2
            // 
            this.BTN2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(533, 399);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(145, 67);
            this.BTN2.TabIndex = 5;
            this.BTN2.Text = "&Salir";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // Facto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.TXTB2);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facto";
            this.Text = "Calculando el factorial de un numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.TextBox TXTB2;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN2;
    }
}