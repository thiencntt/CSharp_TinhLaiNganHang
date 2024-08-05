namespace CSharp_TinhLaiNganHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.nudSoNam = new System.Windows.Forms.NumericUpDown();
            this.cbxLaiSuat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsbKetQua = new System.Windows.Forms.ListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG TÍNH LÃI SUẤT TIẾT KIỆM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lãi suất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số năm gửi:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(278, 59);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(242, 30);
            this.txtSoTien.TabIndex = 1;
            // 
            // nudSoNam
            // 
            this.nudSoNam.Location = new System.Drawing.Point(278, 134);
            this.nudSoNam.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSoNam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoNam.Name = "nudSoNam";
            this.nudSoNam.Size = new System.Drawing.Size(242, 30);
            this.nudSoNam.TabIndex = 2;
            this.nudSoNam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxLaiSuat
            // 
            this.cbxLaiSuat.FormattingEnabled = true;
            this.cbxLaiSuat.Location = new System.Drawing.Point(278, 96);
            this.cbxLaiSuat.Name = "cbxLaiSuat";
            this.cbxLaiSuat.Size = new System.Drawing.Size(242, 31);
            this.cbxLaiSuat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả";
            // 
            // lsbKetQua
            // 
            this.lsbKetQua.FormattingEnabled = true;
            this.lsbKetQua.ItemHeight = 23;
            this.lsbKetQua.Location = new System.Drawing.Point(16, 226);
            this.lsbKetQua.Name = "lsbKetQua";
            this.lsbKetQua.Size = new System.Drawing.Size(612, 326);
            this.lsbKetQua.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(311, 177);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(168, 36);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 580);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lsbKetQua);
            this.Controls.Add(this.cbxLaiSuat);
            this.Controls.Add(this.nudSoNam);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "ỨNG DỤNG TÍNH LÃI SUẤT TIẾT KIỆM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.NumericUpDown nudSoNam;
        private System.Windows.Forms.ComboBox cbxLaiSuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbKetQua;
        private System.Windows.Forms.Button btnTinh;
    }
}

