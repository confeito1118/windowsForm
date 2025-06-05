namespace windowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            file_s = new Button();
            file_n = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 0;
            button1.Text = "PDF作成処理開始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // file_s
            // 
            file_s.Location = new Point(315, 22);
            file_s.Name = "file_s";
            file_s.Size = new Size(111, 23);
            file_s.TabIndex = 1;
            file_s.Text = "ファイルを選ぶ";
            file_s.UseVisualStyleBackColor = true;
            file_s.Click += file_s_Click;
            // 
            // file_n
            // 
            file_n.Location = new Point(6, 22);
            file_n.Name = "file_n";
            file_n.Size = new Size(303, 23);
            file_n.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(file_s);
            groupBox1.Controls.Add(file_n);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 57);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 150);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ぺーでーえふぺい v101";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button file_s;
        private TextBox file_n;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
