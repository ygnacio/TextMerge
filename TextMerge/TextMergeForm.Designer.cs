namespace TextMerge
{
    partial class TextMergeForm
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
            this.prefix = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.delimiter = new System.Windows.Forms.TextBox();
            this.AdditionalText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.MergeBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(9, 57);
            this.prefix.Multiline = true;
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(57, 20);
            this.prefix.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(71, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(205, 130);
            this.textBox.TabIndex = 1;
            // 
            // delimiter
            // 
            this.delimiter.Location = new System.Drawing.Point(291, 63);
            this.delimiter.Multiline = true;
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(57, 20);
            this.delimiter.TabIndex = 2;
            // 
            // AdditionalText
            // 
            this.AdditionalText.Location = new System.Drawing.Point(363, 26);
            this.AdditionalText.Multiline = true;
            this.AdditionalText.Name = "AdditionalText";
            this.AdditionalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AdditionalText.Size = new System.Drawing.Size(205, 130);
            this.AdditionalText.TabIndex = 3;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(9, 229);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultText.Size = new System.Drawing.Size(563, 208);
            this.ResultText.TabIndex = 4;
            // 
            // MergeBtn
            // 
            this.MergeBtn.Location = new System.Drawing.Point(279, 173);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(88, 30);
            this.MergeBtn.TabIndex = 5;
            this.MergeBtn.Text = "Merge";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(279, 443);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(88, 30);
            this.CopyBtn.TabIndex = 6;
            this.CopyBtn.Text = "Copy to Clip";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delimiter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concat every line in the first box with prefix, delimiter and optional a line fro" +
    "m second box";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(71, 173);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 30);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TextMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 491);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.MergeBtn);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.AdditionalText);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.prefix);
            this.MaximizeBox = false;
            this.Name = "TextMergeForm";
            this.Text = "TextMerge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox delimiter;
        private System.Windows.Forms.TextBox AdditionalText;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear;
    }
}

