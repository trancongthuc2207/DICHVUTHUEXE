﻿
namespace DichVuThueXe
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKindAccount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(194, 109);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(152, 20);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(194, 149);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(152, 20);
            this.txtMK.TabIndex = 3;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(217, 197);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(101, 23);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "ĐĂNG NHẬP";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "HỆ THỐNG ĐĂNG NHẬP";
            // 
            // cbbKindAccount
            // 
            this.cbbKindAccount.FormattingEnabled = true;
            this.cbbKindAccount.Items.AddRange(new object[] {
            "Khách Hàng",
            "Hệ Thống"});
            this.cbbKindAccount.Location = new System.Drawing.Point(194, 70);
            this.cbbKindAccount.Name = "cbbKindAccount";
            this.cbbKindAccount.Size = new System.Drawing.Size(152, 21);
            this.cbbKindAccount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng nhập với quyền:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbKindAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HỆ THỐNG ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKindAccount;
        private System.Windows.Forms.Label label4;
    }
}

