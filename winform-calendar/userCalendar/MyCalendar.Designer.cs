namespace WinFormsApp1
{
    partial class MyCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCalendar));
            this.YearLabel = new System.Windows.Forms.Label();
            this.ChooseYearBtn = new System.Windows.Forms.Button();
            this.YearPanel = new System.Windows.Forms.Panel();
            this.ChooseYear = new System.Windows.Forms.ComboBox();
            this.Mo = new System.Windows.Forms.Label();
            this.Tu = new System.Windows.Forms.Label();
            this.We = new System.Windows.Forms.Label();
            this.Th = new System.Windows.Forms.Label();
            this.Fr = new System.Windows.Forms.Label();
            this.Sa = new System.Windows.Forms.Label();
            this.Su = new System.Windows.Forms.Label();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DaysPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ＷeekPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ＭonthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ＭonthLabel = new System.Windows.Forms.Label();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.YearPanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ＷeekPanel.SuspendLayout();
            this.ＭonthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(93, 10);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(49, 20);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "2022";
            this.YearLabel.Click += new System.EventHandler(this.YearLabel_Click);
            // 
            // ChooseYearBtn
            // 
            this.ChooseYearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseYearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ChooseYearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseYearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseYearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.ChooseYearBtn.FlatAppearance.BorderSize = 0;
            this.ChooseYearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChooseYearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChooseYearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseYearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseYearBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseYearBtn.Location = new System.Drawing.Point(139, 9);
            this.ChooseYearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseYearBtn.Name = "ChooseYearBtn";
            this.ChooseYearBtn.Size = new System.Drawing.Size(26, 24);
            this.ChooseYearBtn.TabIndex = 0;
            this.ChooseYearBtn.Text = "▼";
            this.ChooseYearBtn.UseVisualStyleBackColor = false;
            this.ChooseYearBtn.Click += new System.EventHandler(this.ChooseYearBtn_Click);
            // 
            // YearPanel
            // 
            this.YearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.YearPanel.Controls.Add(this.YearLabel);
            this.YearPanel.Controls.Add(this.ChooseYearBtn);
            this.YearPanel.Controls.Add(this.ChooseYear);
            this.YearPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearPanel.Location = new System.Drawing.Point(0, 0);
            this.YearPanel.Margin = new System.Windows.Forms.Padding(0);
            this.YearPanel.Name = "YearPanel";
            this.YearPanel.Size = new System.Drawing.Size(252, 40);
            this.YearPanel.TabIndex = 0;
            // 
            // ChooseYear
            // 
            this.ChooseYear.BackColor = System.Drawing.Color.White;
            this.ChooseYear.CausesValidation = false;
            this.ChooseYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ChooseYear.FormattingEnabled = true;
            this.ChooseYear.Location = new System.Drawing.Point(97, 8);
            this.ChooseYear.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseYear.MaxDropDownItems = 10;
            this.ChooseYear.Name = "ChooseYear";
            this.ChooseYear.Size = new System.Drawing.Size(58, 24);
            this.ChooseYear.TabIndex = 5;
            this.ChooseYear.Visible = false;
            this.ChooseYear.SelectionChangeCommitted += new System.EventHandler(this.ChooseYear_SelectionChangeCommitted);
            // 
            // Mo
            // 
            this.Mo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Mo.Location = new System.Drawing.Point(16, 0);
            this.Mo.Margin = new System.Windows.Forms.Padding(0);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(31, 30);
            this.Mo.TabIndex = 0;
            this.Mo.Text = "Mo";
            this.Mo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tu
            // 
            this.Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Tu.Location = new System.Drawing.Point(109, 0);
            this.Tu.Margin = new System.Windows.Forms.Padding(0);
            this.Tu.Name = "Tu";
            this.Tu.Size = new System.Drawing.Size(31, 30);
            this.Tu.TabIndex = 0;
            this.Tu.Text = "Tu";
            this.Tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // We
            // 
            this.We.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.We.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.We.Location = new System.Drawing.Point(78, 0);
            this.We.Margin = new System.Windows.Forms.Padding(0);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(31, 30);
            this.We.TabIndex = 0;
            this.We.Text = "We";
            this.We.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Th
            // 
            this.Th.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Th.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Th.Location = new System.Drawing.Point(47, 0);
            this.Th.Margin = new System.Windows.Forms.Padding(0);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(31, 30);
            this.Th.TabIndex = 0;
            this.Th.Text = "Th";
            this.Th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fr
            // 
            this.Fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Fr.Location = new System.Drawing.Point(140, 0);
            this.Fr.Margin = new System.Windows.Forms.Padding(0);
            this.Fr.Name = "Fr";
            this.Fr.Size = new System.Drawing.Size(31, 30);
            this.Fr.TabIndex = 0;
            this.Fr.Text = "Fr";
            this.Fr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sa
            // 
            this.Sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Sa.Location = new System.Drawing.Point(171, 0);
            this.Sa.Margin = new System.Windows.Forms.Padding(0);
            this.Sa.Name = "Sa";
            this.Sa.Size = new System.Drawing.Size(31, 30);
            this.Sa.TabIndex = 0;
            this.Sa.Text = "Sa";
            this.Sa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Su
            // 
            this.Su.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Su.Location = new System.Drawing.Point(202, 0);
            this.Su.Margin = new System.Windows.Forms.Padding(0);
            this.Su.Name = "Su";
            this.Su.Size = new System.Drawing.Size(28, 30);
            this.Su.TabIndex = 0;
            this.Su.Text = "Su";
            this.Su.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.Transparent;
            this.BasePanel.Controls.Add(this.BottomPanel);
            this.BasePanel.Controls.Add(this.ＭonthPanel);
            this.BasePanel.Controls.Add(this.YearPanel);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Margin = new System.Windows.Forms.Padding(0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(252, 318);
            this.BasePanel.TabIndex = 2;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DaysPanel);
            this.BottomPanel.Controls.Add(this.ＷeekPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 80);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.BottomPanel.Size = new System.Drawing.Size(252, 238);
            this.BottomPanel.TabIndex = 2;
            // 
            // DaysPanel
            // 
            this.DaysPanel.ColumnCount = 7;
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.DaysPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DaysPanel.Location = new System.Drawing.Point(14, 32);
            this.DaysPanel.Name = "DaysPanel";
            this.DaysPanel.RowCount = 6;
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DaysPanel.Size = new System.Drawing.Size(224, 192);
            this.DaysPanel.TabIndex = 1;
            // 
            // ＷeekPanel
            // 
            this.ＷeekPanel.ColumnCount = 7;
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ＷeekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ＷeekPanel.Controls.Add(this.label1, 0, 0);
            this.ＷeekPanel.Controls.Add(this.label2, 1, 0);
            this.ＷeekPanel.Controls.Add(this.label3, 2, 0);
            this.ＷeekPanel.Controls.Add(this.label4, 3, 0);
            this.ＷeekPanel.Controls.Add(this.label5, 4, 0);
            this.ＷeekPanel.Controls.Add(this.label6, 5, 0);
            this.ＷeekPanel.Controls.Add(this.label7, 6, 0);
            this.ＷeekPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ＷeekPanel.Location = new System.Drawing.Point(14, 0);
            this.ＷeekPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ＷeekPanel.Name = "ＷeekPanel";
            this.ＷeekPanel.RowCount = 1;
            this.ＷeekPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ＷeekPanel.Size = new System.Drawing.Size(224, 32);
            this.ＷeekPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(32, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(64, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "We";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(96, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Th";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(128, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fr";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(160, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(192, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Su";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ＭonthPanel
            // 
            this.ＭonthPanel.ColumnCount = 3;
            this.ＭonthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ＭonthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ＭonthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ＭonthPanel.Controls.Add(this.ＭonthLabel, 1, 0);
            this.ＭonthPanel.Controls.Add(this.LeftBtn, 0, 0);
            this.ＭonthPanel.Controls.Add(this.RightBtn, 2, 0);
            this.ＭonthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ＭonthPanel.Location = new System.Drawing.Point(0, 40);
            this.ＭonthPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ＭonthPanel.Name = "ＭonthPanel";
            this.ＭonthPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ＭonthPanel.RowCount = 1;
            this.ＭonthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ＭonthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ＭonthPanel.Size = new System.Drawing.Size(252, 40);
            this.ＭonthPanel.TabIndex = 1;
            // 
            // ＭonthLabel
            // 
            this.ＭonthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ＭonthLabel.AutoSize = true;
            this.ＭonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ＭonthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.ＭonthLabel.Location = new System.Drawing.Point(107, 10);
            this.ＭonthLabel.Name = "ＭonthLabel";
            this.ＭonthLabel.Size = new System.Drawing.Size(37, 20);
            this.ＭonthLabel.TabIndex = 0;
            this.ＭonthLabel.Text = "Oct";
            this.ＭonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftBtn
            // 
            this.LeftBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftBtn.BackgroundImage")));
            this.LeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LeftBtn.FlatAppearance.BorderSize = 0;
            this.LeftBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftBtn.Location = new System.Drawing.Point(15, 5);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(30, 30);
            this.LeftBtn.TabIndex = 1;
            this.LeftBtn.TabStop = false;
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightBtn.BackgroundImage")));
            this.RightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RightBtn.FlatAppearance.BorderSize = 0;
            this.RightBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightBtn.Location = new System.Drawing.Point(206, 5);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(30, 30);
            this.RightBtn.TabIndex = 2;
            this.RightBtn.TabStop = false;
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // MyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BasePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MyCalendar";
            this.Size = new System.Drawing.Size(252, 318);
            this.YearPanel.ResumeLayout(false);
            this.YearPanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ＷeekPanel.ResumeLayout(false);
            this.ＷeekPanel.PerformLayout();
            this.ＭonthPanel.ResumeLayout(false);
            this.ＭonthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ChooseYearBtn;
        private System.Windows.Forms.Panel YearPanel;
        private System.Windows.Forms.Label Mo;
        private System.Windows.Forms.Label Th;
        private System.Windows.Forms.Label Fr;
        private System.Windows.Forms.Label Tu;
        private System.Windows.Forms.Label Sa;
        private System.Windows.Forms.Label Su;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TableLayoutPanel ＷeekPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel ＭonthPanel;
        private System.Windows.Forms.Label ＭonthLabel;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RightBtn;
        public System.Windows.Forms.TableLayoutPanel DaysPanel;
        private System.Windows.Forms.ComboBox ChooseYear;
        protected System.Windows.Forms.Label YearLabel;
    }
}
