
namespace BabenNew
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label18 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            panel9 = new Panel();
            label16 = new Label();
            panel10 = new Panel();
            label13 = new Label();
            panel11 = new Panel();
            label14 = new Label();
            panel12 = new Panel();
            label15 = new Label();
            panel13 = new Panel();
            label12 = new Label();
            panel14 = new Panel();
            label17 = new Label();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            button4 = new Button();
            label23 = new Label();
            numericUpDown3 = new NumericUpDown();
            label24 = new Label();
            label21 = new Label();
            numericUpDown1 = new NumericUpDown();
            label19 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 69);
            label1.TabIndex = 0;
            label1.Text = "Ezan Vakitleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(282, 78);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "00.00.0000";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(24, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 42);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 39);
            label4.TabIndex = 5;
            label4.Text = "Güneş";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(24, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 83);
            panel2.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(39, 0);
            label18.Name = "label18";
            label18.Size = new Size(196, 39);
            label18.TabIndex = 6;
            label18.Text = "Kalan Süre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 39);
            label5.Name = "label5";
            label5.Size = new Size(157, 39);
            label5.TabIndex = 5;
            label5.Text = "00:00:00";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label6);
            panel3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel3.Location = new Point(317, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 38);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 5;
            label6.Text = "00:00";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(label7);
            panel4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel4.Location = new Point(317, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(113, 27);
            panel4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 5;
            label7.Text = "İmsak";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(label8);
            panel5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel5.Location = new Point(436, 129);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 38);
            panel5.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 6;
            label8.Text = "00:00";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DimGray;
            panel6.Controls.Add(label9);
            panel6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel6.Location = new Point(436, 167);
            panel6.Name = "panel6";
            panel6.Size = new Size(113, 27);
            panel6.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 5;
            label9.Text = "Güneş";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(label10);
            panel7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel7.Location = new Point(555, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(113, 38);
            panel7.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 7;
            label10.Text = "00:00";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DimGray;
            panel8.Controls.Add(label11);
            panel8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel8.Location = new Point(555, 167);
            panel8.Name = "panel8";
            panel8.Size = new Size(113, 27);
            panel8.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 5;
            label11.Text = "Öğle";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Controls.Add(label16);
            panel9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel9.Location = new Point(555, 200);
            panel9.Name = "panel9";
            panel9.Size = new Size(113, 38);
            panel9.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(67, 25);
            label16.TabIndex = 10;
            label16.Text = "00:00";
            // 
            // panel10
            // 
            panel10.BackColor = Color.DimGray;
            panel10.Controls.Add(label13);
            panel10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel10.Location = new Point(555, 238);
            panel10.Name = "panel10";
            panel10.Size = new Size(113, 27);
            panel10.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(60, 25);
            label13.TabIndex = 5;
            label13.Text = "Yatsı";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Controls.Add(label14);
            panel11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel11.Location = new Point(436, 200);
            panel11.Name = "panel11";
            panel11.Size = new Size(113, 38);
            panel11.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 25);
            label14.TabIndex = 9;
            label14.Text = "00:00";
            // 
            // panel12
            // 
            panel12.BackColor = Color.DimGray;
            panel12.Controls.Add(label15);
            panel12.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel12.Location = new Point(436, 238);
            panel12.Name = "panel12";
            panel12.Size = new Size(113, 27);
            panel12.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(78, 25);
            label15.TabIndex = 5;
            label15.Text = "Aksam";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Controls.Add(label12);
            panel13.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel13.Location = new Point(317, 200);
            panel13.Name = "panel13";
            panel13.Size = new Size(113, 38);
            panel13.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 8;
            label12.Text = "00:00";
            // 
            // panel14
            // 
            panel14.BackColor = Color.DimGray;
            panel14.Controls.Add(label17);
            panel14.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel14.Location = new Point(317, 238);
            panel14.Name = "panel14";
            panel14.Size = new Size(113, 27);
            panel14.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(0, 0);
            label17.Name = "label17";
            label17.Size = new Size(63, 25);
            label17.TabIndex = 5;
            label17.Text = "İkindi";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FloralWhite;
            groupBox1.Location = new Point(76, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 163);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ayarlar";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FloralWhite;
            linkLabel1.Location = new Point(198, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 24);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "İlçe Kodu :";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.FloralWhite;
            button4.Location = new Point(280, 102);
            button4.Name = "button4";
            button4.Size = new Size(268, 48);
            button4.TabIndex = 21;
            button4.Text = "Ayarları Sıfırla";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Location = new Point(515, 69);
            label23.Name = "label23";
            label23.Size = new Size(33, 24);
            label23.TabIndex = 14;
            label23.Text = "dk";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(474, 67);
            numericUpDown3.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(35, 33);
            numericUpDown3.TabIndex = 13;
            numericUpDown3.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Location = new Point(262, 69);
            label24.Name = "label24";
            label24.Size = new Size(200, 24);
            label24.TabIndex = 12;
            label24.Text = "Susturma Bekleme :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Location = new Point(217, 66);
            label21.Name = "label21";
            label21.Size = new Size(33, 24);
            label21.TabIndex = 9;
            label21.Text = "dk";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(164, 64);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 33);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Location = new Point(7, 66);
            label19.Name = "label19";
            label19.Size = new Size(147, 24);
            label19.TabIndex = 5;
            label19.Text = "Fire Bekleme :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 32);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 33);
            textBox1.TabIndex = 2;
            textBox1.Text = "9541";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(630, 12);
            button1.Name = "button1";
            button1.Size = new Size(57, 48);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(567, 12);
            button2.Name = "button2";
            button2.Size = new Size(57, 48);
            button2.TabIndex = 19;
            button2.Text = "_";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.FloralWhite;
            button3.Location = new Point(88, 373);
            button3.Name = "button3";
            button3.Size = new Size(268, 48);
            button3.TabIndex = 20;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Ezan Vakti V2";
            notifyIcon1.BalloonTipTitle = "Ben buradayım çift tıklayarak tekrar açabilirsin.";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Ezan Duyarlı Hoparlör";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 446);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel11);
            Controls.Add(panel12);
            Controls.Add(panel5);
            Controls.Add(panel13);
            Controls.Add(panel6);
            Controls.Add(panel14);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(11, 9, 11, 9);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ezan Vakti V2";
            TopMost = true;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

