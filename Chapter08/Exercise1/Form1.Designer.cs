
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.tbLeepYear = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(53, 236);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(441, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(591, 241);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(88, 31);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudYear.Location = new System.Drawing.Point(53, 54);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 31);
            this.nudYear.TabIndex = 2;
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonth.Location = new System.Drawing.Point(204, 54);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(120, 31);
            this.nudMonth.TabIndex = 3;
            // 
            // nudDay
            // 
            this.nudDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDay.Location = new System.Drawing.Point(358, 54);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(69, 31);
            this.nudDay.TabIndex = 4;
            // 
            // tbLeepYear
            // 
            this.tbLeepYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeepYear.Location = new System.Drawing.Point(53, 183);
            this.tbLeepYear.Name = "tbLeepYear";
            this.tbLeepYear.Size = new System.Drawing.Size(441, 31);
            this.tbLeepYear.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAge.Location = new System.Drawing.Point(53, 323);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(130, 31);
            this.tbAge.TabIndex = 5;
            // 
            // btAge
            // 
            this.btAge.Location = new System.Drawing.Point(591, 325);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(88, 29);
            this.btAge.TabIndex = 6;
            this.btAge.Text = "実行";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // dTP
            // 
            this.dTP.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dTP.Location = new System.Drawing.Point(53, 128);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(229, 28);
            this.dTP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dTP);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbLeepYear);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.TextBox tbLeepYear;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.DateTimePicker dTP;
    }
}

