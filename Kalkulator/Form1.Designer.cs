
namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKalkulator = new System.Windows.Forms.Label();
            this.lblMasukkanNilai1 = new System.Windows.Forms.Label();
            this.lblMasukkanNilai2 = new System.Windows.Forms.Label();
            this.lblHasilNilai = new System.Windows.Forms.Label();
            this.txtNilai1 = new System.Windows.Forms.TextBox();
            this.txtNilai2 = new System.Windows.Forms.TextBox();
            this.txtHasilNilai = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.lblKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKalkulator
            // 
            this.lblKalkulator.AutoSize = true;
            this.lblKalkulator.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKalkulator.Location = new System.Drawing.Point(329, 41);
            this.lblKalkulator.Name = "lblKalkulator";
            this.lblKalkulator.Size = new System.Drawing.Size(160, 31);
            this.lblKalkulator.TabIndex = 0;
            this.lblKalkulator.Text = "KALKULATOR";
            this.lblKalkulator.Click += new System.EventHandler(this.lblKalkulator_Click);
            // 
            // lblMasukkanNilai1
            // 
            this.lblMasukkanNilai1.AutoSize = true;
            this.lblMasukkanNilai1.Location = new System.Drawing.Point(77, 144);
            this.lblMasukkanNilai1.Name = "lblMasukkanNilai1";
            this.lblMasukkanNilai1.Size = new System.Drawing.Size(115, 20);
            this.lblMasukkanNilai1.TabIndex = 1;
            this.lblMasukkanNilai1.Text = "Maukkan Nilai 1";
            // 
            // lblMasukkanNilai2
            // 
            this.lblMasukkanNilai2.AutoSize = true;
            this.lblMasukkanNilai2.Location = new System.Drawing.Point(77, 188);
            this.lblMasukkanNilai2.Name = "lblMasukkanNilai2";
            this.lblMasukkanNilai2.Size = new System.Drawing.Size(115, 20);
            this.lblMasukkanNilai2.TabIndex = 2;
            this.lblMasukkanNilai2.Text = "Maukkan Nilai 2";
            // 
            // lblHasilNilai
            // 
            this.lblHasilNilai.AutoSize = true;
            this.lblHasilNilai.Location = new System.Drawing.Point(77, 244);
            this.lblHasilNilai.Name = "lblHasilNilai";
            this.lblHasilNilai.Size = new System.Drawing.Size(77, 20);
            this.lblHasilNilai.TabIndex = 3;
            this.lblHasilNilai.Text = "Hasil Nilai";
            // 
            // txtNilai1
            // 
            this.txtNilai1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNilai1.Location = new System.Drawing.Point(263, 141);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(125, 27);
            this.txtNilai1.TabIndex = 4;
            // 
            // txtNilai2
            // 
            this.txtNilai2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNilai2.Location = new System.Drawing.Point(263, 188);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(125, 27);
            this.txtNilai2.TabIndex = 5;
            // 
            // txtHasilNilai
            // 
            this.txtHasilNilai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHasilNilai.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHasilNilai.Location = new System.Drawing.Point(263, 244);
            this.txtHasilNilai.Name = "txtHasilNilai";
            this.txtHasilNilai.ReadOnly = true;
            this.txtHasilNilai.Size = new System.Drawing.Size(125, 27);
            this.txtHasilNilai.TabIndex = 6;
            this.txtHasilNilai.TextChanged += new System.EventHandler(this.txtHasilNilai_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(439, 135);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(94, 39);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(439, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(439, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKurang.Location = new System.Drawing.Point(560, 135);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(94, 39);
            this.btnKurang.TabIndex = 10;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // lblKali
            // 
            this.lblKali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKali.Location = new System.Drawing.Point(560, 188);
            this.lblKali.Name = "lblKali";
            this.lblKali.Size = new System.Drawing.Size(94, 39);
            this.lblKali.TabIndex = 11;
            this.lblKali.Text = "Kali";
            this.lblKali.UseVisualStyleBackColor = true;
            this.lblKali.Click += new System.EventHandler(this.lblKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBagi.Location = new System.Drawing.Point(560, 244);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(94, 39);
            this.btnBagi.TabIndex = 12;
            this.btnBagi.Text = "Bagi";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.lblKali);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtHasilNilai);
            this.Controls.Add(this.txtNilai2);
            this.Controls.Add(this.txtNilai1);
            this.Controls.Add(this.lblHasilNilai);
            this.Controls.Add(this.lblMasukkanNilai2);
            this.Controls.Add(this.lblMasukkanNilai1);
            this.Controls.Add(this.lblKalkulator);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalkulator;
        private System.Windows.Forms.Label lblMasukkanNilai1;
        private System.Windows.Forms.Label lblMasukkanNilai2;
        private System.Windows.Forms.Label lblHasilNilai;
        private System.Windows.Forms.TextBox txtNilai1;
        private System.Windows.Forms.TextBox txtNilai2;
        private System.Windows.Forms.TextBox txtHasilNilai;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button lblKali;
        private System.Windows.Forms.Button btnBagi;
    }
}

