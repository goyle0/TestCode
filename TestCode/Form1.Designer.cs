namespace TestCode
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputText = new System.Windows.Forms.RichTextBox();
            this.GetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(356, 12);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(432, 413);
            this.OutputText.TabIndex = 0;
            this.OutputText.Text = "";
            // 
            // GetBtn
            // 
            this.GetBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.GetBtn.Location = new System.Drawing.Point(12, 12);
            this.GetBtn.Name = "GetBtn";
            this.GetBtn.Size = new System.Drawing.Size(191, 97);
            this.GetBtn.TabIndex = 1;
            this.GetBtn.Text = "取　込";
            this.GetBtn.UseVisualStyleBackColor = false;
            this.GetBtn.Click += new System.EventHandler(this.GetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Brown;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.DeleteBtn.Location = new System.Drawing.Point(12, 159);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(191, 97);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "削　除";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.GetBtn);
            this.Controls.Add(this.OutputText);
            this.Name = "Form1";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputText;
        private System.Windows.Forms.Button GetBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

