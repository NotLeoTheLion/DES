namespace DES
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxText = new TextBox();
            txtBoxKey = new TextBox();
            comboBox = new ComboBox();
            comboBoxMode = new ComboBox();
            txtBoxResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Text";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 27);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 113);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "Cypher/Decypher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 113);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Mode";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 291);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Result";
            // 
            // txtBoxText
            // 
            txtBoxText.Location = new Point(12, 50);
            txtBoxText.Multiline = true;
            txtBoxText.Name = "txtBoxText";
            txtBoxText.Size = new Size(265, 51);
            txtBoxText.TabIndex = 5;
            txtBoxText.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(344, 50);
            txtBoxKey.MaxLength = 8;
            txtBoxKey.Multiline = true;
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(270, 34);
            txtBoxKey.TabIndex = 6;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Cypher", "Decypher" });
            comboBox.Location = new Point(12, 136);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(265, 28);
            comboBox.TabIndex = 7;
            // 
            // comboBoxMode
            // 
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "ECB", "CBC", "CFB" });
            comboBoxMode.Location = new Point(344, 136);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(269, 28);
            comboBoxMode.TabIndex = 8;
            // 
            // txtBoxResult
            // 
            txtBoxResult.Location = new Point(12, 315);
            txtBoxResult.Multiline = true;
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.Size = new Size(602, 123);
            txtBoxResult.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(241, 179);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 10;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 251);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 11;
            button2.Text = "from file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(183, 251);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Save to file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(625, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBoxResult);
            Controls.Add(comboBoxMode);
            Controls.Add(comboBox);
            Controls.Add(txtBoxKey);
            Controls.Add(txtBoxText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxText;
        private TextBox txtBoxKey;
        private ComboBox comboBox;
        private ComboBox comboBoxMode;
        private TextBox txtBoxResult;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
