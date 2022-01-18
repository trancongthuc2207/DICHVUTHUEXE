
namespace DichVuThueXe.GUI
{
    partial class MENU_ChucNang_DatXe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.cbb_LOAIDV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.lOAIDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIDVTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.LOAIDVTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(545, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG ĐẶT XE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbb_LOAIDV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẢNG THÔNG TIN ĐẶT XE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGia);
            this.groupBox2.Controls.Add(this.lblMa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl12);
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "* Thông tin dịch vụ";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(157, 56);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(19, 13);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "....";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(157, 25);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(19, 13);
            this.lblMa.TabIndex = 7;
            this.lblMa.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "+ Giá:";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(46, 25);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(69, 13);
            this.lbl12.TabIndex = 7;
            this.lbl12.Text = "+ Mã dịch vụ";
            // 
            // cbb_LOAIDV
            // 
            this.cbb_LOAIDV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAIDVBindingSource, "MaL", true));
            this.cbb_LOAIDV.DataSource = this.lOAIDVBindingSource;
            this.cbb_LOAIDV.DisplayMember = "Tenloai";
            this.cbb_LOAIDV.FormattingEnabled = true;
            this.cbb_LOAIDV.Location = new System.Drawing.Point(128, 29);
            this.cbb_LOAIDV.Name = "cbb_LOAIDV";
            this.cbb_LOAIDV.Size = new System.Drawing.Size(121, 21);
            this.cbb_LOAIDV.TabIndex = 5;
            this.cbb_LOAIDV.ValueMember = "MaL";
            this.cbb_LOAIDV.SelectedIndexChanged += new System.EventHandler(this.SelectItem_LOAIDV);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại hình dịch vụ:";
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIDVBindingSource
            // 
            this.lOAIDVBindingSource.DataMember = "LOAIDV";
            this.lOAIDVBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // lOAIDVTableAdapter
            // 
            this.lOAIDVTableAdapter.ClearBeforeFill = true;
            // 
            // MENU_ChucNang_DatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MENU_ChucNang_DatXe";
            this.Text = "MENU_ChucNang_DatXe";
            this.Load += new System.EventHandler(this.MENU_ChucNang_DatXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LOAIDV;



        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl12;
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource lOAIDVBindingSource;
        private HTTX_DataSetTableAdapters.LOAIDVTableAdapter lOAIDVTableAdapter;
    }
}