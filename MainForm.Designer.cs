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
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(16, 60);
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
            tabControl1.Location = new System.Drawing.Point(142, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(635, 339);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(627, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "건축";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(627, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "구조";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(627, 311);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "설비";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(627, 311);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "데이터";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(16, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "슬래브 타입";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(148, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "슬래브 타입";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(148, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(148, 60);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(121, 23);
            button2.TabIndex = 3;
            button2.Text = "슬래브 생성";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(789, 363);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Sample Test";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}
