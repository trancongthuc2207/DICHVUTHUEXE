
namespace DichVuThueXe.GUI
{
    partial class SELECT_DANGKY
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
            this.btnDK_NV = new System.Windows.Forms.Button();
            this.btnDK_KH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDK_NV
            // 
            this.btnDK_NV.Location = new System.Drawing.Point(76, 87);
            this.btnDK_NV.Name = "btnDK_NV";
            this.btnDK_NV.Size = new System.Drawing.Size(200, 129);
            this.btnDK_NV.TabIndex = 0;
            this.btnDK_NV.Text = "NHÂN VIÊN";
            this.btnDK_NV.UseVisualStyleBackColor = true;
            this.btnDK_NV.Click += new System.EventHandler(this.btnDK_NV_Click);
            // 
            // btnDK_KH
            // 
            this.btnDK_KH.Location = new System.Drawing.Point(363, 87);
            this.btnDK_KH.Name = "btnDK_KH";
            this.btnDK_KH.Size = new System.Drawing.Size(208, 129);
            this.btnDK_KH.TabIndex = 1;
            this.btnDK_KH.Text = "KHÁCH HÁNG";
            this.btnDK_KH.UseVisualStyleBackColor = true;
            this.btnDK_KH.Click += new System.EventHandler(this.btnDK_KH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG KÝ VỚI TƯ CÁCH:";
            // 
            // SELECT_DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDK_KH);
            this.Controls.Add(this.btnDK_NV);
            this.Name = "SELECT_DANGKY";
            this.Text = "SELECT_DANGKY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDK_NV;
        private System.Windows.Forms.Button btnDK_KH;
        private System.Windows.Forms.Label label1;
    }
}