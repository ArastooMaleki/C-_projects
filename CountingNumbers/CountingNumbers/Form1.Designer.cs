namespace CountingNumbers
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
            groupBoxMain = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            StartTB = new TextBox();
            EndTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DivisibleCB = new ComboBox();
            Bold = new CheckBox();
            Italic = new CheckBox();
            ExitB = new Button();
            CountB = new Button();
            groupBoxColor = new GroupBox();
            ColorBlue = new CheckBox();
            ColorGreen = new CheckBox();
            ColorRed = new CheckBox();
            groupBoxMain.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxColor.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(richTextBox1);
            groupBoxMain.Controls.Add(groupBox1);
            groupBoxMain.Dock = DockStyle.Fill;
            groupBoxMain.Location = new Point(0, 0);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(1220, 570);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Main";
            groupBoxMain.Enter += groupBoxMain_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Font = new Font("Segoe UI", 9F);
            richTextBox1.Location = new Point(26, 324);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1168, 216);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "hello";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(StartTB);
            groupBox1.Controls.Add(EndTB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DivisibleCB);
            groupBox1.Controls.Add(Bold);
            groupBox1.Controls.Add(Italic);
            groupBox1.Controls.Add(ExitB);
            groupBox1.Controls.Add(CountB);
            groupBox1.Controls.Add(groupBoxColor);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(26, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1168, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setting";
            // 
            // StartTB
            // 
            StartTB.Location = new Point(233, 58);
            StartTB.Name = "StartTB";
            StartTB.Size = new Size(125, 39);
            StartTB.TabIndex = 0;
            // 
            // EndTB
            // 
            EndTB.Location = new Point(585, 58);
            EndTB.Name = "EndTB";
            EndTB.Size = new Size(125, 39);
            EndTB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 155);
            label3.Name = "label3";
            label3.Size = new Size(199, 32);
            label3.TabIndex = 9;
            label3.Text = "Divisible Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 58);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 8;
            label2.Text = "Start From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(500, 58);
            label1.Name = "label1";
            label1.Size = new Size(39, 32);
            label1.TabIndex = 7;
            label1.Text = "To";
            // 
            // DivisibleCB
            // 
            DivisibleCB.FormattingEnabled = true;
            DivisibleCB.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            DivisibleCB.Location = new Point(500, 152);
            DivisibleCB.Name = "DivisibleCB";
            DivisibleCB.Size = new Size(151, 39);
            DivisibleCB.TabIndex = 3;
            // 
            // Bold
            // 
            Bold.AutoSize = true;
            Bold.Location = new Point(48, 173);
            Bold.Name = "Bold";
            Bold.Size = new Size(84, 36);
            Bold.TabIndex = 5;
            Bold.Text = "Bold";
            Bold.UseVisualStyleBackColor = true;
            Bold.CheckedChanged += Bold_CheckedChanged;
            // 
            // Italic
            // 
            Italic.AutoSize = true;
            Italic.Location = new Point(48, 231);
            Italic.Name = "Italic";
            Italic.Size = new Size(85, 36);
            Italic.TabIndex = 4;
            Italic.Text = "Italic";
            Italic.UseVisualStyleBackColor = true;
            Italic.CheckedChanged += Italic_CheckedChanged;
            // 
            // ExitB
            // 
            ExitB.Location = new Point(546, 238);
            ExitB.Name = "ExitB";
            ExitB.Size = new Size(123, 48);
            ExitB.TabIndex = 3;
            ExitB.Text = "Exit";
            ExitB.UseVisualStyleBackColor = true;
            ExitB.Click += ExitB_Click;
            // 
            // CountB
            // 
            CountB.Location = new Point(351, 238);
            CountB.Name = "CountB";
            CountB.Size = new Size(130, 48);
            CountB.TabIndex = 4;
            CountB.Text = "Count";
            CountB.UseVisualStyleBackColor = true;
            CountB.Click += CountB_Click;
            // 
            // groupBoxColor
            // 
            groupBoxColor.Controls.Add(ColorBlue);
            groupBoxColor.Controls.Add(ColorGreen);
            groupBoxColor.Controls.Add(ColorRed);
            groupBoxColor.Location = new Point(877, 61);
            groupBoxColor.Name = "groupBoxColor";
            groupBoxColor.Size = new Size(285, 206);
            groupBoxColor.TabIndex = 1;
            groupBoxColor.TabStop = false;
            groupBoxColor.Text = "Select Color";
            // 
            // ColorBlue
            // 
            ColorBlue.AutoSize = true;
            ColorBlue.Location = new Point(6, 112);
            ColorBlue.Name = "ColorBlue";
            ColorBlue.Size = new Size(83, 36);
            ColorBlue.TabIndex = 2;
            ColorBlue.Text = "Blue";
            ColorBlue.UseVisualStyleBackColor = true;
            ColorBlue.CheckedChanged += ColorBlue_CheckedChanged;
            // 
            // ColorGreen
            // 
            ColorGreen.AutoSize = true;
            ColorGreen.Location = new Point(6, 82);
            ColorGreen.Name = "ColorGreen";
            ColorGreen.Size = new Size(100, 36);
            ColorGreen.TabIndex = 1;
            ColorGreen.Text = "Green";
            ColorGreen.UseVisualStyleBackColor = true;
            ColorGreen.CheckedChanged += ColorGreen_CheckedChanged;
            // 
            // ColorRed
            // 
            ColorRed.AutoSize = true;
            ColorRed.Location = new Point(6, 52);
            ColorRed.Name = "ColorRed";
            ColorRed.Size = new Size(76, 36);
            ColorRed.TabIndex = 0;
            ColorRed.Text = "Red";
            ColorRed.UseVisualStyleBackColor = true;
            ColorRed.CheckedChanged += ColorRed_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 570);
            Controls.Add(groupBoxMain);
            Name = "Form1";
            Text = "Form1";
            groupBoxMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxColor.ResumeLayout(false);
            groupBoxColor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private GroupBox groupBoxColor;
        private CheckBox ColorGreen;
        private CheckBox ColorRed;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox DivisibleCB;
        private CheckBox Bold;
        private CheckBox Italic;
        private Button ExitB;
        private Button CountB;
        private TextBox StartTB;
        private TextBox EndTB;
        private CheckBox ColorBlue;
    }
}