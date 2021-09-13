
namespace RssReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btRead = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(175, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(637, 30);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(16, 152);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(258, 319);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.Click += new System.EventHandler(this.lbTitles_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(281, 152);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1137, 501);
            this.wbBrowser.TabIndex = 3;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(818, 16);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(88, 23);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb2.Location = new System.Drawing.Point(391, 58);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(1027, 91);
            this.lb2.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDate.Location = new System.Drawing.Point(56, 85);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(297, 30);
            this.tbDate.TabIndex = 6;
            this.tbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(151, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "更新日時";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(56, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = "web表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(27, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(160, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "→";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 665);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

