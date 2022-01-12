
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDK_NV
            // 
            this.btnDK_NV.BackColor = System.Drawing.Color.Transparent;
            this.btnDK_NV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDK_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK_NV.ForeColor = System.Drawing.Color.Indigo;
            this.btnDK_NV.Image = global::DichVuThueXe.Properties.Resources.NhanVien;
            this.btnDK_NV.Location = new System.Drawing.Point(76, 76);
            this.btnDK_NV.Name = "btnDK_NV";
            this.btnDK_NV.Size = new System.Drawing.Size(200, 129);
            this.btnDK_NV.TabIndex = 0;
            this.btnDK_NV.UseVisualStyleBackColor = false;
            this.btnDK_NV.Click += new System.EventHandler(this.btnDK_NV_Click);
            // 
            // btnDK_KH
            // 
            this.btnDK_KH.BackColor = System.Drawing.Color.Transparent;
            this.btnDK_KH.BackgroundImage = global::DichVuThueXe.Properties.Resources.KhachHang;
            this.btnDK_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDK_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDK_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK_KH.Location = new System.Drawing.Point(366, 76);
            this.btnDK_KH.Name = "btnDK_KH";
            this.btnDK_KH.Size = new System.Drawing.Size(211, 129);
            this.btnDK_KH.TabIndex = 1;
            this.btnDK_KH.UseVisualStyleBackColor = false;
            this.btnDK_KH.Click += new System.EventHandler(this.btnDK_KH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG KÝ VỚI TƯ CÁCH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(107, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(390, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "KHÁCH HÀNG";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::DichVuThueXe.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 36);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SELECT_DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DichVuThueXe.Properties.Resources.Background_GD_DK;
            this.ClientSize = new System.Drawing.Size(660, 225);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}