
namespace QLSinhVienNhom
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.labelMHP = new System.Windows.Forms.Label();
            this.labelDiem = new System.Windows.Forms.Label();
            this.labelMSV = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtDiem);
            this.panel1.Controls.Add(this.txtMaHP);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.labelMHP);
            this.panel1.Controls.Add(this.labelDiem);
            this.panel1.Controls.Add(this.labelMSV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 161);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(602, 57);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(110, 22);
            this.txtDiem.TabIndex = 5;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(335, 57);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(110, 22);
            this.txtMaHP.TabIndex = 4;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(61, 57);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(110, 22);
            this.txtMaSV.TabIndex = 3;
            // 
            // labelMHP
            // 
            this.labelMHP.AutoSize = true;
            this.labelMHP.Location = new System.Drawing.Point(332, 27);
            this.labelMHP.Name = "labelMHP";
            this.labelMHP.Size = new System.Drawing.Size(93, 17);
            this.labelMHP.TabIndex = 2;
            this.labelMHP.Text = "Mã Học Phần";
            this.labelMHP.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDiem
            // 
            this.labelDiem.AutoSize = true;
            this.labelDiem.Location = new System.Drawing.Point(599, 27);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(40, 17);
            this.labelDiem.TabIndex = 1;
            this.labelDiem.Text = "Điểm";
            // 
            // labelMSV
            // 
            this.labelMSV.AutoSize = true;
            this.labelMSV.Location = new System.Drawing.Point(58, 27);
            this.labelMSV.Name = "labelMSV";
            this.labelMSV.Size = new System.Drawing.Size(91, 17);
            this.labelMSV.TabIndex = 0;
            this.labelMSV.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaHP,
            this.DIEMTHI});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MASV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MAHP";
            this.MaHP.HeaderText = "Mã Học Phần";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.DataPropertyName = "DIEMTHI";
            this.DIEMTHI.HeaderText = "Điểm";
            this.DIEMTHI.MinimumWidth = 6;
            this.DIEMTHI.Name = "DIEMTHI";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label labelMHP;
        private System.Windows.Forms.Label labelDiem;
        private System.Windows.Forms.Label labelMSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
    }
}