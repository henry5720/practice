namespace userCalendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myCalendar2 = new WinFormsApp1.MyCalendar();
            myCalendar1 = new WinFormsApp1.MyCalendar();
            SuspendLayout();
            // 
            // myCalendar2
            // 
            myCalendar2.BackColor = System.Drawing.Color.White;
            myCalendar2.Location = new System.Drawing.Point(81, 66);
            myCalendar2.Margin = new System.Windows.Forms.Padding(0);
            myCalendar2.Name = "myCalendar2";
            myCalendar2.Size = new System.Drawing.Size(324, 403);
            myCalendar2.TabIndex = 1;
            myCalendar2.Click_Event += myCalendar2_Click_Event;
            // 
            // myCalendar1
            // 
            myCalendar1.BackColor = System.Drawing.Color.White;
            myCalendar1.Location = new System.Drawing.Point(573, 65);
            myCalendar1.Margin = new System.Windows.Forms.Padding(0);
            myCalendar1.Name = "myCalendar1";
            myCalendar1.Size = new System.Drawing.Size(324, 403);
            myCalendar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1029, 570);
            Controls.Add(myCalendar1);
            Controls.Add(myCalendar2);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private WinFormsApp1.MyCalendar myCalendar2;
        private WinFormsApp1.MyCalendar myCalendar1;
    }
}
