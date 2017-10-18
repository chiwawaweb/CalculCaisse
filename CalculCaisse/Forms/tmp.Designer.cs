namespace CalculCaisse.Forms
{
    partial class tmp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblB200 = new System.Windows.Forms.Label();
            this.txtB200 = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.txtTotalBillets = new System.Windows.Forms.TextBox();
            this.txtTotalB500 = new System.Windows.Forms.TextBox();
            this.lblB500 = new System.Windows.Forms.Label();
            this.txtB500 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            // 
            // lblB200
            // 
            this.lblB200.AutoSize = true;
            this.lblB200.Location = new System.Drawing.Point(425, 224);
            this.lblB200.Name = "lblB200";
            this.lblB200.Size = new System.Drawing.Size(36, 20);
            this.lblB200.TabIndex = 14;
            this.lblB200.Text = "200";
            // 
            // txtB200
            // 
            this.txtB200.Location = new System.Drawing.Point(494, 224);
            this.txtB200.Name = "txtB200";
            this.txtB200.Size = new System.Drawing.Size(100, 26);
            this.txtB200.TabIndex = 13;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(848, 613);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(163, 61);
            this.btnCalcul.TabIndex = 12;
            this.btnCalcul.Text = "CALCUL";
            this.btnCalcul.UseVisualStyleBackColor = true;
            // 
            // txtTotalBillets
            // 
            this.txtTotalBillets.Location = new System.Drawing.Point(641, 524);
            this.txtTotalBillets.Name = "txtTotalBillets";
            this.txtTotalBillets.ReadOnly = true;
            this.txtTotalBillets.Size = new System.Drawing.Size(100, 26);
            this.txtTotalBillets.TabIndex = 11;
            // 
            // txtTotalB500
            // 
            this.txtTotalB500.Location = new System.Drawing.Point(641, 181);
            this.txtTotalB500.Name = "txtTotalB500";
            this.txtTotalB500.ReadOnly = true;
            this.txtTotalB500.Size = new System.Drawing.Size(100, 26);
            this.txtTotalB500.TabIndex = 10;
            // 
            // lblB500
            // 
            this.lblB500.AutoSize = true;
            this.lblB500.Location = new System.Drawing.Point(425, 181);
            this.lblB500.Name = "lblB500";
            this.lblB500.Size = new System.Drawing.Size(36, 20);
            this.lblB500.TabIndex = 9;
            this.lblB500.Text = "500";
            // 
            // txtB500
            // 
            this.txtB500.Location = new System.Drawing.Point(494, 181);
            this.txtB500.Name = "txtB500";
            this.txtB500.Size = new System.Drawing.Size(100, 26);
            this.txtB500.TabIndex = 8;
            // 
            // tmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 855);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblB200);
            this.Controls.Add(this.txtB200);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtTotalBillets);
            this.Controls.Add(this.txtTotalB500);
            this.Controls.Add(this.lblB500);
            this.Controls.Add(this.txtB500);
            this.Name = "tmp";
            this.Text = "tmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblB200;
        private System.Windows.Forms.TextBox txtB200;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.TextBox txtTotalBillets;
        private System.Windows.Forms.TextBox txtTotalB500;
        private System.Windows.Forms.Label lblB500;
        private System.Windows.Forms.TextBox txtB500;
    }
}