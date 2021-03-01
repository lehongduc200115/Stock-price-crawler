namespace TradingProjectWF
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThuMuc = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbBatDau = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đường dẫn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbThuMuc
            // 
            this.tbThuMuc.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbThuMuc.Enabled = false;
            this.tbThuMuc.Location = new System.Drawing.Point(211, 204);
            this.tbThuMuc.Name = "tbThuMuc";
            this.tbThuMuc.ReadOnly = true;
            this.tbThuMuc.Size = new System.Drawing.Size(521, 22);
            this.tbThuMuc.TabIndex = 2;
            this.tbThuMuc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(105, 262);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(97, 25);
            this.lbTrangThai.TabIndex = 4;
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTrangThai.Click += new System.EventHandler(this.lbTrangThai_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(211, 262);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(521, 25);
            this.lbThongBao.TabIndex = 5;
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(738, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 84);
            this.label2.TabIndex = 7;
            this.label2.Text = "Export Data Chứng Khoán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(393, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bắt đầu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbBatDau
            // 
            this.lbBatDau.AutoSize = true;
            this.lbBatDau.ForeColor = System.Drawing.Color.Red;
            this.lbBatDau.Location = new System.Drawing.Point(390, 314);
            this.lbBatDau.Name = "lbBatDau";
            this.lbBatDau.Size = new System.Drawing.Size(146, 17);
            this.lbBatDau.TabIndex = 9;
            this.lbBatDau.Text = "Sẽ chạy trong 10 giây";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(962, 443);
            this.Controls.Add(this.lbBatDau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.tbThuMuc);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Export tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThuMuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbBatDau;
        private System.Windows.Forms.Timer timer2;
    }
}

