namespace baitaplonhedieuhanh
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
            this.nudgio = new System.Windows.Forms.NumericUpDown();
            this.nudphut = new System.Windows.Forms.NumericUpDown();
            this.nudgiay = new System.Windows.Forms.NumericUpDown();
            this.lbgio = new System.Windows.Forms.Label();
            this.lbphut = new System.Windows.Forms.Label();
            this.lbgiay = new System.Windows.Forms.Label();
            this.btshutdown = new System.Windows.Forms.Button();
            this.btrestart = new System.Windows.Forms.Button();
            this.bthuylenh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudgio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudphut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiay)).BeginInit();
            this.SuspendLayout();
            // 
            // nudgio
            // 
            this.nudgio.Location = new System.Drawing.Point(125, 52);
            this.nudgio.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudgio.Name = "nudgio";
            this.nudgio.Size = new System.Drawing.Size(58, 22);
            this.nudgio.TabIndex = 0;
            // 
            // nudphut
            // 
            this.nudphut.Location = new System.Drawing.Point(372, 52);
            this.nudphut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudphut.Name = "nudphut";
            this.nudphut.Size = new System.Drawing.Size(68, 22);
            this.nudphut.TabIndex = 1;
            this.nudphut.ValueChanged += new System.EventHandler(this.nudphut_ValueChanged);
            // 
            // nudgiay
            // 
            this.nudgiay.Location = new System.Drawing.Point(643, 52);
            this.nudgiay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudgiay.Name = "nudgiay";
            this.nudgiay.Size = new System.Drawing.Size(60, 22);
            this.nudgiay.TabIndex = 2;
            this.nudgiay.ValueChanged += new System.EventHandler(this.nudgiay_ValueChanged);
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Location = new System.Drawing.Point(190, 56);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(30, 17);
            this.lbgio.TabIndex = 3;
            this.lbgio.Text = "Giờ";
            // 
            // lbphut
            // 
            this.lbphut.AutoSize = true;
            this.lbphut.Location = new System.Drawing.Point(458, 57);
            this.lbphut.Name = "lbphut";
            this.lbphut.Size = new System.Drawing.Size(37, 17);
            this.lbphut.TabIndex = 4;
            this.lbphut.Text = "Phút";
            // 
            // lbgiay
            // 
            this.lbgiay.AutoSize = true;
            this.lbgiay.Location = new System.Drawing.Point(729, 56);
            this.lbgiay.Name = "lbgiay";
            this.lbgiay.Size = new System.Drawing.Size(37, 17);
            this.lbgiay.TabIndex = 5;
            this.lbgiay.Text = "Giây";
            // 
            // btshutdown
            // 
            this.btshutdown.BackColor = System.Drawing.Color.Red;
            this.btshutdown.Location = new System.Drawing.Point(107, 146);
            this.btshutdown.Name = "btshutdown";
            this.btshutdown.Size = new System.Drawing.Size(113, 54);
            this.btshutdown.TabIndex = 6;
            this.btshutdown.Text = "Tắt Máy";
            this.btshutdown.UseVisualStyleBackColor = false;
            this.btshutdown.Click += new System.EventHandler(this.btshutdown_Click);
            // 
            // btrestart
            // 
            this.btrestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btrestart.Location = new System.Drawing.Point(372, 146);
            this.btrestart.Name = "btrestart";
            this.btrestart.Size = new System.Drawing.Size(123, 54);
            this.btrestart.TabIndex = 7;
            this.btrestart.Text = "Khởi động lại";
            this.btrestart.UseVisualStyleBackColor = false;
            this.btrestart.Click += new System.EventHandler(this.btrestart_Click);
            // 
            // bthuylenh
            // 
            this.bthuylenh.Location = new System.Drawing.Point(643, 146);
            this.bthuylenh.Name = "bthuylenh";
            this.bthuylenh.Size = new System.Drawing.Size(123, 54);
            this.bthuylenh.TabIndex = 8;
            this.bthuylenh.Text = "Hủy Lệnh";
            this.bthuylenh.UseVisualStyleBackColor = true;
            this.bthuylenh.Click += new System.EventHandler(this.bthuylenh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(61, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "word";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(193, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.Location = new System.Drawing.Point(337, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "notepad";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(461, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "paint";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(597, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 51);
            this.button5.TabIndex = 13;
            this.button5.Text = "Calculator";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "winword",
            "excel",
            "notepad",
            "calculator",
            "mspaint"});
            this.comboBox1.Location = new System.Drawing.Point(61, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(379, 39);
            this.comboBox1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(498, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "đóng ứng dụng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(334, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "bật tắt một số app";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "hẹn giờ tắt máy và khởi động lại máy ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bthuylenh);
            this.Controls.Add(this.btrestart);
            this.Controls.Add(this.btshutdown);
            this.Controls.Add(this.lbgiay);
            this.Controls.Add(this.lbphut);
            this.Controls.Add(this.lbgio);
            this.Controls.Add(this.nudgiay);
            this.Controls.Add(this.nudphut);
            this.Controls.Add(this.nudgio);
            this.Name = "Form1";
            this.Text = "Hẹn GIờ ";
            ((System.ComponentModel.ISupportInitialize)(this.nudgio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudphut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudgio;
        private System.Windows.Forms.NumericUpDown nudphut;
        private System.Windows.Forms.NumericUpDown nudgiay;
        private System.Windows.Forms.Label lbgio;
        private System.Windows.Forms.Label lbphut;
        private System.Windows.Forms.Label lbgiay;
        private System.Windows.Forms.Button btshutdown;
        private System.Windows.Forms.Button btrestart;
        private System.Windows.Forms.Button bthuylenh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

