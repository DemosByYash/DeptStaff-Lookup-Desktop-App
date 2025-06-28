namespace App1
{
    partial class DeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptForm));
            labelT = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Close = new Button();
            Next = new Button();
            ConStatusProgress = new ProgressBar();
            ConStatus = new Label();
            SuspendLayout();
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.BackColor = Color.Orange;
            labelT.Font = new Font("Microsoft New Tai Lue", 20F, FontStyle.Italic);
            labelT.Location = new Point(110, 10);
            labelT.Name = "labelT";
            labelT.Size = new Size(311, 45);
            labelT.TabIndex = 0;
            labelT.Text = "Department Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(47, 126);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 1;
            label1.Text = "Label 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 126);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Cornsilk;
            textBox1.Location = new Point(153, 121);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(304, 48);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Cornsilk;
            textBox2.Location = new Point(153, 212);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(304, 48);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cornsilk;
            textBox3.Location = new Point(153, 310);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(304, 48);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(47, 228);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 8;
            label2.Text = "Label 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(47, 326);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 9;
            label3.Text = "Label 3";
            // 
            // Close
            // 
            Close.BackColor = Color.Red;
            Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Close.Location = new Point(285, 389);
            Close.Name = "Close";
            Close.Size = new Size(157, 54);
            Close.TabIndex = 11;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click_1;
            // 
            // Next
            // 
            Next.BackColor = Color.Silver;
            Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Next.Location = new Point(62, 389);
            Next.Name = "Next";
            Next.Size = new Size(157, 54);
            Next.TabIndex = 12;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // ConStatusProgress
            // 
            ConStatusProgress.Location = new Point(162, 65);
            ConStatusProgress.Name = "ConStatusProgress";
            ConStatusProgress.Size = new Size(199, 15);
            ConStatusProgress.TabIndex = 13;
            // 
            // ConStatus
            // 
            ConStatus.AutoSize = true;
            ConStatus.Location = new Point(193, 83);
            ConStatus.Name = "ConStatus";
            ConStatus.Size = new Size(96, 20);
            ConStatus.TabIndex = 14;
            ConStatus.Text = "Connecting....";
            // 
            // DeptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(ConStatus);
            Controls.Add(ConStatusProgress);
            Controls.Add(Next);
            Controls.Add(Close);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(labelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeptForm";
            Text = "Department Lookup";
            Load += DeptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelT;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Button Close;
        private Button Next;
        private ProgressBar ConStatusProgress;
        private Label ConStatus;
    }
}
