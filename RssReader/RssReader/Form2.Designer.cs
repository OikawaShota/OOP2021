
namespace RssReader
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
            this.btBack = new System.Windows.Forms.Button();
            this.btForword = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(31, 28);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(110, 55);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btForword
            // 
            this.btForword.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForword.Location = new System.Drawing.Point(147, 28);
            this.btForword.Name = "btForword";
            this.btForword.Size = new System.Drawing.Size(105, 55);
            this.btForword.TabIndex = 1;
            this.btForword.Text = "進む";
            this.btForword.UseVisualStyleBackColor = true;
            this.btForword.Click += new System.EventHandler(this.btForword_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(31, 111);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(984, 498);
            this.wbBrowser.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 621);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btForword);
            this.Controls.Add(this.btBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForword;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}