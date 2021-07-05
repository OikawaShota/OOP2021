
namespace Exercise {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btToday = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tss = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btToday
            // 
            this.btToday.Location = new System.Drawing.Point(60, 33);
            this.btToday.Name = "btToday";
            this.btToday.Size = new System.Drawing.Size(111, 44);
            this.btToday.TabIndex = 0;
            this.btToday.Text = "今日";
            this.btToday.UseVisualStyleBackColor = true;
            this.btToday.Click += new System.EventHandler(this.btToday_Click);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(60, 104);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(339, 122);
            this.tbDate.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(86, 22);
            this.tss.Text = "toolStripLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 481);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.btToday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToday;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tss;
    }
}

