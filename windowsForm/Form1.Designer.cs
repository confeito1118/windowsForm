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
            progressBar1 = new ProgressBar();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            終了XToolStripMenuItem = new ToolStripMenuItem();
            使い方HToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 57);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step 2";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 169);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(463, 23);
            progressBar1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, 使い方HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(495, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 終了XToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了XToolStripMenuItem
            // 
            終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            終了XToolStripMenuItem.Size = new Size(113, 22);
            終了XToolStripMenuItem.Text = "終了(&X)";
            終了XToolStripMenuItem.Click += 終了XToolStripMenuItem_Click;
            // 
            // 使い方HToolStripMenuItem
            // 
            使い方HToolStripMenuItem.Name = "使い方HToolStripMenuItem";
            使い方HToolStripMenuItem.Size = new Size(70, 20);
            使い方HToolStripMenuItem.Text = "使い方(&H)";
            使い方HToolStripMenuItem.Click += 使い方HToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 214);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ぺーでーえふぺい v120";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button file_s;
        private TextBox file_n;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 終了XToolStripMenuItem;
        private ToolStripMenuItem 使い方HToolStripMenuItem;
    }
}
