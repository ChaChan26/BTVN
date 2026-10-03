namespace QuanLySinhVien
{
    partial class frmQuanLySinhVien
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtMaSV = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            textBox21 = new TextBox();
            textBox18 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox12 = new TextBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            textBox13 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            textBox8 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox14 = new TextBox();
            textBox17 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(558, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 32);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(639, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 32);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 34);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(104, 45);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 34);
            txtMaSV.TabIndex = 9;
            txtMaSV.TextChanged += dateTimePicker1_ValueChanged;
            txtMaSV.Enter += txtMaSinhVien_Enter;
            txtMaSV.Leave += txtMaSV_Leave;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = SystemColors.Menu;
            maskedTextBox4.BorderStyle = BorderStyle.None;
            maskedTextBox4.Location = new Point(0, 85);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(98, 27);
            maskedTextBox4.TabIndex = 11;
            maskedTextBox4.Text = "Ngày sinh";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 34);
            textBox3.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Location = new Point(867, 128);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 16;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(375, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 34);
            numericUpDown1.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox21);
            groupBox1.Controls.Add(textBox18);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(maskedTextBox4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1101, 196);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(841, 45);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(125, 34);
            textBox21.TabIndex = 39;
            // 
            // textBox18
            // 
            textBox18.BackColor = SystemColors.Menu;
            textBox18.BorderStyle = BorderStyle.None;
            textBox18.Location = new Point(738, 45);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(97, 27);
            textBox18.TabIndex = 38;
            textBox18.Text = "Trạng thái";
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.Location = new Point(967, 128);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 37;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(767, 128);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 36;
            button2.Text = "Làm lại";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Location = new Point(667, 128);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 35;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Menu;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(300, 130);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(55, 27);
            textBox10.TabIndex = 32;
            textBox10.Text = "Điểm";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.Menu;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Location = new Point(404, 90);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(91, 27);
            textBox11.TabIndex = 33;
            textBox11.Text = "Lớp học";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Menu;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(6, 132);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(42, 27);
            textBox9.TabIndex = 31;
            textBox9.Text = "SDT";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(0, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 26;
            textBox4.Text = "Thông tin sinh viên";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(525, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 36);
            comboBox1.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(235, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(67, 27);
            textBox7.TabIndex = 29;
            textBox7.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Menu;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(461, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 27);
            textBox6.TabIndex = 28;
            textBox6.Text = "Giới tính";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(6, 51);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(65, 27);
            textBox5.TabIndex = 27;
            textBox5.Text = "Mã SV";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 398);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1101, 188);
            dataGridView1.TabIndex = 27;
            // 
            // textBox12
            // 
            textBox12.BackColor = SystemColors.Menu;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Location = new Point(12, 348);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(244, 27);
            textBox12.TabIndex = 28;
            textBox12.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox15);
            groupBox2.Controls.Add(textBox16);
            groupBox2.Controls.Add(textBox19);
            groupBox2.Controls.Add(textBox20);
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 106);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Location = new Point(900, 56);
            button6.Name = "button6";
            button6.Size = new Size(161, 37);
            button6.TabIndex = 42;
            button6.Text = "Hiển thị tất cả";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(790, 55);
            button5.Name = "button5";
            button5.Size = new Size(94, 37);
            button5.TabIndex = 41;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.Menu;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Location = new Point(525, 62);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(55, 27);
            textBox13.TabIndex = 40;
            textBox13.Text = "Điểm";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(600, 58);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 34);
            numericUpDown2.TabIndex = 39;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Menu;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(0, 58);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(79, 27);
            textBox8.TabIndex = 38;
            textBox8.Text = "Từ khóa";
            // 
            // textBox15
            // 
            textBox15.BackColor = SystemColors.Menu;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Location = new Point(0, 12);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(244, 27);
            textBox15.TabIndex = 26;
            textBox15.Text = "Search";
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // textBox16
            // 
            textBox16.BackColor = SystemColors.Menu;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Location = new Point(235, 62);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(84, 27);
            textBox16.TabIndex = 29;
            textBox16.Text = "Lớp học";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(325, 58);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(125, 34);
            textBox19.TabIndex = 24;
            // 
            // textBox20
            // 
            textBox20.BackColor = SystemColors.Window;
            textBox20.Location = new Point(85, 58);
            textBox20.Name = "textBox20";
            textBox20.PlaceholderText = "Mã,họ tên,...";
            textBox20.Size = new Size(125, 34);
            textBox20.TabIndex = 9;
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.Menu;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Location = new Point(768, 348);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(79, 27);
            textBox14.TabIndex = 40;
            textBox14.Text = "Tổng số";
            // 
            // textBox17
            // 
            textBox17.BackColor = SystemColors.Menu;
            textBox17.Location = new Point(853, 348);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(125, 34);
            textBox17.TabIndex = 39;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 659);
            Controls.Add(textBox14);
            Controls.Add(textBox17);
            Controls.Add(groupBox2);
            Controls.Add(textBox12);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmQuanLySinhVien";
            Text = "Quan ly sinh vien";
            TopMost = true;
            Load += frmQuanLySinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMaSV;
        private MaskedTextBox maskedTextBox4;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox textBox12;
        private GroupBox groupBox2;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox13;
        private NumericUpDown numericUpDown2;
        private TextBox textBox8;
        private TextBox textBox14;
        private TextBox textBox17;
        private TextBox textBox21;
        private TextBox textBox18;
        private Button button6;
        private Button button5;
    }
}
