
namespace Exercise3 {
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
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPass1
            // 
            this.tbPass1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPass1.Location = new System.Drawing.Point(203, 181);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.Size = new System.Drawing.Size(420, 26);
            this.tbPass1.TabIndex = 0;
            // 
            // tbPass2
            // 
            this.tbPass2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPass2.Location = new System.Drawing.Point(203, 279);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.Size = new System.Drawing.Size(420, 26);
            this.tbPass2.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(352, 60);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(130, 74);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "開始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbEnd.Location = new System.Drawing.Point(289, 362);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(269, 71);
            this.tbEnd.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPass1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbEnd;
    }
}

