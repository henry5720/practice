namespace WinFormsApp1
{
    partial class SingleDate
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
            this.daysBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysBtn
            // 
            this.daysBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.daysBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daysBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysBtn.FlatAppearance.BorderSize = 0;
            this.daysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.daysBtn.Location = new System.Drawing.Point(0, 0);
            this.daysBtn.Margin = new System.Windows.Forms.Padding(0);
            this.daysBtn.Name = "daysBtn";
            this.daysBtn.Size = new System.Drawing.Size(32, 32);
            this.daysBtn.TabIndex = 0;
            this.daysBtn.Tag = "";
            this.daysBtn.Text = "00";
            this.daysBtn.UseVisualStyleBackColor = true;
            // 
            // SingleDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.daysBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SingleDate";
            this.Size = new System.Drawing.Size(32, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button daysBtn;
    }
}
