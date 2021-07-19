
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btReadAll = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(62, 69);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(598, 368);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(62, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 39);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く…";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(172, 32);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 19);
            this.tbKey.TabIndex = 2;
            // 
            // btReadAll
            // 
            this.btReadAll.Location = new System.Drawing.Point(322, 25);
            this.btReadAll.Name = "btReadAll";
            this.btReadAll.Size = new System.Drawing.Size(75, 23);
            this.btReadAll.TabIndex = 3;
            this.btReadAll.Text = "ReadAll";
            this.btReadAll.UseVisualStyleBackColor = true;
            this.btReadAll.Click += new System.EventHandler(this.btReadAll_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(431, 25);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(75, 23);
            this.btReadLines.TabIndex = 4;
            this.btReadLines.Text = "ReadLines";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 466);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btReadAll);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btReadAll;
        private System.Windows.Forms.Button btReadLines;
    }
}

