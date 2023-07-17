namespace WindowsFormsApp1
{
    partial class menu
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
            this.btnCau01 = new System.Windows.Forms.Button();
            this.btnCau02 = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCau01
            // 
            this.btnCau01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCau01.Location = new System.Drawing.Point(37, 85);
            this.btnCau01.Name = "btnCau01";
            this.btnCau01.Size = new System.Drawing.Size(86, 63);
            this.btnCau01.TabIndex = 0;
            this.btnCau01.Text = "Cau01";
            this.btnCau01.UseVisualStyleBackColor = false;
            this.btnCau01.Click += new System.EventHandler(this.btnCau01_Click);
            // 
            // btnCau02
            // 
            this.btnCau02.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCau02.Location = new System.Drawing.Point(150, 85);
            this.btnCau02.Name = "btnCau02";
            this.btnCau02.Size = new System.Drawing.Size(86, 63);
            this.btnCau02.TabIndex = 0;
            this.btnCau02.Text = "Cau02";
            this.btnCau02.UseVisualStyleBackColor = false;
            this.btnCau02.Click += new System.EventHandler(this.btnCau02_Click);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbClose.Location = new System.Drawing.Point(677, 9);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(31, 29);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btnCau02);
            this.Controls.Add(this.btnCau01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCau01;
        private System.Windows.Forms.Button btnCau02;
        private System.Windows.Forms.Label lbClose;
    }
}