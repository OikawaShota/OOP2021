
namespace StopWatch {
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
            this.lbTimer = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTimer.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimer.Location = new System.Drawing.Point(31, 51);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(456, 61);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(52, 168);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(144, 68);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Location = new System.Drawing.Point(295, 168);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(144, 68);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
    }
}

