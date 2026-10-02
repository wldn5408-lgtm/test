namespace Modless
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            button5 = new System.Windows.Forms.Button();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            comboBox4 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            button4 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBox6 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            comboBox5 = new System.Windows.Forms.ComboBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            comboBox7 = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(17, 76);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 23);
            button1.TabIndex = 0;
            button1.Text = "슬래브 생성";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(102, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "위유진";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(133, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(635, 337);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(627, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "건축";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new System.Drawing.Point(404, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(190, 88);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "실내재료마감";
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(17, 51);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(155, 23);
            button5.TabIndex = 15;
            button5.Text = "마감 생성";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(122, 23);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(50, 19);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "천장";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(75, 24);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(38, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "벽";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(17, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(50, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "바닥";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new System.Drawing.Point(21, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(573, 172);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "객체 생성";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "슬래브 타입";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(428, 79);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "천장 높이 지정";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(17, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(291, 78);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 13;
            label6.Text = "벽 높이 지정";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(291, 130);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(121, 23);
            button2.TabIndex = 3;
            button2.Text = "벽 생성";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(428, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(121, 23);
            textBox2.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(291, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(291, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(121, 23);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(291, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "벽 타입";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(428, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "천장 타입";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(154, 76);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(121, 23);
            button3.TabIndex = 6;
            button3.Text = "기둥 생성";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(428, 47);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(121, 23);
            comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(154, 47);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(428, 131);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(121, 23);
            button4.TabIndex = 9;
            button4.Text = "천장 생성";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(154, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "기둥 타입";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Location = new System.Drawing.Point(21, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(366, 88);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "레벨 지정";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new System.Drawing.Point(173, 49);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new System.Drawing.Size(124, 23);
            comboBox6.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(173, 27);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 15);
            label9.TabIndex = 19;
            label9.Text = "상단 레벨";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(19, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 15);
            label8.TabIndex = 17;
            label8.Text = "베이스 레벨";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new System.Drawing.Point(19, 49);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(124, 23);
            comboBox5.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(627, 309);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "구조";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(627, 309);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "설비";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(comboBox7);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(627, 309);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "데이터";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(486, 128);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(121, 23);
            button7.TabIndex = 4;
            button7.Text = "내보내기";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(486, 90);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(121, 23);
            button6.TabIndex = 3;
            button6.Text = "불러오기";
            button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(486, 19);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(71, 15);
            label10.TabIndex = 2;
            label10.Text = "데이터 선택";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new System.Drawing.Point(486, 40);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new System.Drawing.Size(121, 23);
            comboBox7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(460, 297);
            dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(773, 356);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Sample Test";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
