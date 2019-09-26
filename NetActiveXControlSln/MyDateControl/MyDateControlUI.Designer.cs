namespace MyDateControl
{
    partial class MyDateControlUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdDisplayToday = new System.Windows.Forms.Button();
            this.cmdGetOSVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdDisplayToday
            // 
            this.cmdDisplayToday.Location = new System.Drawing.Point(108, 85);
            this.cmdDisplayToday.Name = "cmdDisplayToday";
            this.cmdDisplayToday.Size = new System.Drawing.Size(147, 60);
            this.cmdDisplayToday.TabIndex = 0;
            this.cmdDisplayToday.Text = "cmdDisplayToday";
            this.cmdDisplayToday.UseVisualStyleBackColor = true;
            this.cmdDisplayToday.Click += new System.EventHandler(this.cmdDisplayToday_Click);
            // 
            // cmdGetOSVer
            // 
            this.cmdGetOSVer.Location = new System.Drawing.Point(292, 85);
            this.cmdGetOSVer.Name = "cmdGetOSVer";
            this.cmdGetOSVer.Size = new System.Drawing.Size(141, 60);
            this.cmdGetOSVer.TabIndex = 1;
            this.cmdGetOSVer.Text = "cmdGetOSVer";
            this.cmdGetOSVer.UseVisualStyleBackColor = true;
            this.cmdGetOSVer.Click += new System.EventHandler(this.cmdGetOSVer_Click);
            // 
            // MyDateControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdGetOSVer);
            this.Controls.Add(this.cmdDisplayToday);
            this.Name = "MyDateControlUI";
            this.Size = new System.Drawing.Size(536, 311);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDisplayToday;
        private System.Windows.Forms.Button cmdGetOSVer;
    }
}
