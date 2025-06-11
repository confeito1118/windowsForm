namespace windowsForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 135);
            label1.TabIndex = 0;
            label1.Text = "ぺーでーえふぺいはExcelをシートごとに1枚ずつPDFに変換するソフトです。\r\nStep1でExcelファイルを選択\r\nStep2でボタンを押すと変換処理が始まります\r\n下のバーは進捗具合を表しています。\r\n\r\nまだまだできたてなので意地悪をするとエラーを吐く可能性があります。\r\n例)シート数999枚だとタイムアウトしないか 等\r\n\r\n不具合等あれば、松本までご連絡ください。";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 166);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "ぺーでーえふぺい";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}