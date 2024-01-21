namespace TypingApp
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
            this.QuestionValueLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MissLabel = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.QuestionCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionValueLabel
            // 
            this.QuestionValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionValueLabel.AutoSize = true;
            this.QuestionValueLabel.Location = new System.Drawing.Point(161, 77);
            this.QuestionValueLabel.Name = "QuestionValueLabel";
            this.QuestionValueLabel.Size = new System.Drawing.Size(29, 12);
            this.QuestionValueLabel.TabIndex = 2;
            this.QuestionValueLabel.Text = "label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // MissLabel
            // 
            this.MissLabel.AutoSize = true;
            this.MissLabel.Location = new System.Drawing.Point(161, 114);
            this.MissLabel.Name = "MissLabel";
            this.MissLabel.Size = new System.Drawing.Size(0, 12);
            this.MissLabel.TabIndex = 4;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(232, 126);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(53, 12);
            this.Counter.TabIndex = 5;
            this.Counter.Text = "正解数：0";
            // 
            // QuestionCount
            // 
            this.QuestionCount.AutoSize = true;
            this.QuestionCount.Location = new System.Drawing.Point(232, 114);
            this.QuestionCount.Name = "QuestionCount";
            this.QuestionCount.Size = new System.Drawing.Size(41, 12);
            this.QuestionCount.TabIndex = 6;
            this.QuestionCount.Text = "問題数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 245);
            this.Controls.Add(this.QuestionCount);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.MissLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionValueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuestionValueLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MissLabel;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label QuestionCount;
    }
}

