namespace App1
{
    partial class EmpLookUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpLookUp));
            LabelTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            Next = new Button();
            Update = new Button();
            New = new Button();
            Delete = new Button();
            Insert = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.DarkOrange;
            LabelTitle.Font = new Font("Microsoft New Tai Lue", 20F, FontStyle.Italic);
            LabelTitle.Location = new Point(267, 15);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(276, 45);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Employee Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(80, 90);
            label1.Name = "label1";
            label1.Size = new Size(68, 37);
            label1.TabIndex = 2;
            label1.Text = "Eno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(80, 143);
            label2.Name = "label2";
            label2.Size = new Size(103, 37);
            label2.TabIndex = 3;
            label2.Text = "Ename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(80, 199);
            label3.Name = "label3";
            label3.Size = new Size(65, 37);
            label3.TabIndex = 4;
            label3.Text = "Job:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(80, 256);
            label4.Name = "label4";
            label4.Size = new Size(94, 37);
            label4.TabIndex = 5;
            label4.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(80, 316);
            label5.Name = "label5";
            label5.Size = new Size(94, 37);
            label5.TabIndex = 6;
            label5.Text = "Status:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(190, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(518, 34);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(190, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(518, 34);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(190, 202);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(518, 34);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(190, 260);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(518, 34);
            textBox4.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Segoe UI", 13F);
            checkBox1.Location = new Point(191, 330);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 11;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            Next.Font = new Font("Segoe UI", 10F);
            Next.Location = new Point(111, 386);
            Next.Name = "Next";
            Next.Size = new Size(137, 41);
            Next.TabIndex = 12;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 10F);
            Update.Location = new Point(111, 441);
            Update.Name = "Update";
            Update.Size = new Size(137, 41);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // New
            // 
            New.Font = new Font("Segoe UI", 10F);
            New.Location = new Point(328, 386);
            New.Name = "New";
            New.Size = new Size(137, 41);
            New.TabIndex = 14;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += button3_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 10F);
            Delete.Location = new Point(328, 441);
            Delete.Name = "Delete";
            Delete.Size = new Size(137, 41);
            Delete.TabIndex = 15;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Insert
            // 
            Insert.Enabled = false;
            Insert.Font = new Font("Segoe UI", 10F);
            Insert.Location = new Point(550, 386);
            Insert.Name = "Insert";
            Insert.Size = new Size(137, 41);
            Insert.TabIndex = 16;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 10F);
            Close.Location = new Point(550, 441);
            Close.Name = "Close";
            Close.Size = new Size(137, 41);
            Close.TabIndex = 17;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // EmpLookUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(Close);
            Controls.Add(Insert);
            Controls.Add(Delete);
            Controls.Add(New);
            Controls.Add(Update);
            Controls.Add(Next);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmpLookUp";
            Text = "Employee LookUp";
            FormClosing += EmpLookUp_FormClosing;
            Load += EmpLookUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private Button Next;
        private Button Update;
        private Button New;
        private Button Delete;
        private Button Insert;
        private Button Close;
    }
}