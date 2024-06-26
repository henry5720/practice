using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using userCalendar.Properties;

namespace WinFormsApp1
{
    [ToolboxItem(true)]
    public partial class MyCalendar : UserControl
    {
        #region 設定變數
        // [變數] 主色
        public System.Drawing.Color mainColor = Color.FromArgb(87, 191, 212);
        public System.Drawing.Color dateColor = Color.FromArgb(67, 67, 67);

        // [當前時間]
        public DateTime now = DateTime.Now;

        // [年月日]
        public int year, month, today;

        // [上下月變數]
        public int lastMonthDays;
        public int nextMonthDays;

        // [選中當天時間]
        public DateTime choose_Day = DateTime.Now;

        public int DayWeek = 0;
        #endregion

        public MyCalendar()
        {
            InitializeComponent();

            // [旋轉背景]
            this.RightBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);

            // [當前年, 月]
            year = now.Year;
            month = now.Month;
            today = now.Day;

            // [執行function]
            DisplayDays();
            DisplayMonths();
            DisplayYears();
            SetWindowRegion();
        }

        #region 圓角視窗
        /// <summary>
        /// 設置視窗 Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 4);
            this.Region = new Region(FormPath);

        }
        /// <summary>
        /// 繪製圓角路徑
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();


            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        /// <summary>
        /// 視窗size發生改變時重新設置Region屬性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }
        #endregion

        // [顯示日期]
        public void DisplayDays()
        {
            #region 設定變數
            // [當月1號]
            DateTime startMonth = new DateTime(year, month, 1);

            // [當月天數] 
            int days = DateTime.DaysInMonth(year, month);

            // [當月1號星期]
            int dayOfTheWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d"));
            if (dayOfTheWeek == 0)
            {
                dayOfTheWeek = 7;
            }
            DayWeek = dayOfTheWeek;
            Trace.WriteLine($"星期幾: {dayOfTheWeek}");
            //MessageBox.Show($"星期幾: {dayOfTheWeek}");

            // [上月天數]
            if (month != 1)
            {
                lastMonthDays = DateTime.DaysInMonth(year, month - 1);
            }
            else
            {
                lastMonthDays = DateTime.DaysInMonth(year - 1, 12);
            }

            // [下月日期]
            nextMonthDays = 1;

            // [上月剩餘格子]
            int restDay = dayOfTheWeek - 1;
            #endregion
            // [添加日期格子] 上月
            for (int i = dayOfTheWeek; i > 1; i--)
            {
                BlankDate unblank = new BlankDate();

                // [修改日期文字] 使用BlankDays方法
                unblank.BlankDays(lastMonthDays - restDay + 1);
                DaysPanel.Controls.Add(unblank);
                restDay--;
            }

            // [添加日期格子] 當月&下月
            for (int i = 1; i <= 42; i++)
            {
                // [當月日期]
                if (i <= days)
                {
                    SingleDate ucdays = new SingleDate();
                    // [日期格子文字] 使用days方法
                    ucdays.days(i);
                    // [日期格子Tag]
                    ucdays.daysBtn.Tag = i;
                    // [日期格子事件]
                    ucdays.daysBtn.Click += new EventHandler(Ucdays_Click);

                    // [當天日期格子] 改背景色
                    if (new DateTime(year, month, i).ToString("d") ==now.ToString("d")) 
                    {
                        ucdays.todayColor();
                    }

                    DaysPanel.Controls.Add(ucdays);
                }
                // [下月日期]
                if (i > days)
                {
                    BlankDate unblank = new BlankDate();

                    // [修改日期文字] 使用BlankDays方法
                    unblank.BlankDays(nextMonthDays);
                    DaysPanel.Controls.Add(unblank);
                    nextMonthDays++;
                }
            }
        }

        // [點擊日期格子] 更改背景
        public void Ucdays_Click(object sender, EventArgs e)
        {
            // 遍歷daysPanel元件 -> 移除背景(當天不移除)
            foreach (var control in DaysPanel.Controls)
            {
                // 是SingleDate
                if (control is SingleDate)
                {
                    SingleDate ucdays = (SingleDate)control;

                    // 底下的按鈕, 才是點擊對象
                    int ucdaysTag = Convert.ToInt32(ucdays.daysBtn.Tag);

                    //  (點擊的日期 == 現在日期) -> 不改背景色
                    if (new DateTime(year, month, ucdaysTag).ToString("d") == DateTime.Now.ToString("d"))
                        continue;

                    // [移除背景]
                    ucdays.daysBtn.BackgroundImage = base.BackgroundImage;
                }
            }

            // [目前點擊對象]
            Button button = (Button)sender;
            int thisButtonTag = Convert.ToInt32(button.Tag);

            // [目前點擊對象] 時間
            choose_Day = new DateTime(year, month, thisButtonTag);

            // [調用自訂義事件] Click_Event
            if (Click_Event != null)
            {
                Click_Event.Invoke(this, e);
                // Debug.WriteLine("this: " + this);
            }

            //  (點擊的日期 == 現在日期) -> 不改背景色
            if (new DateTime(year, month, thisButtonTag).ToString("d") == DateTime.Now.ToString("d"))
                return;
            button.BackgroundImage = Resources.clickBackGround;
            // Debug.WriteLine("thisButtonTag: " + thisButtonTag);

            // Debug.WriteLine("點擊的日期: "+choose_Day.ToString("d"));
        }

        // [添加自訂義事件] 修改時間
        public event EventHandler Click_Event;


        // [顯示月份]
        private void DisplayMonths()
        {
            DateTime startMonth = new DateTime(year, month, 1);
            CultureInfo ci = new CultureInfo("en-US");
            var month_name = startMonth.ToString("MMM", ci);
            ＭonthLabel.Text = month_name;
        }

        // [顯示年分]
        private void DisplayYears()
        {
            YearLabel.Text = Convert.ToString(year);
        }

        // [點擊年份, 顯示下拉選單] 
        private void YearLabel_Click(object sender, EventArgs e)
        {
            ChooseYear.DroppedDown = true;
            AddDataSource();
        }

        //[點擊年份旁下箭頭, 顯示下拉選單]
        private void ChooseYearBtn_Click(object sender, EventArgs e)
        {
            ChooseYear.DroppedDown = true;
            AddDataSource();
        }

        // [年份選單] 增加資料
        private void AddDataSource()
        {
            // [List] 存儲年份
            List<string> yearItems = new List<string>() { };

            // [List增加] 前4年
            for (int i = 0; i > 0; i--)
            {
                yearItems.Add((year - i).ToString());
            }
            // [List增加] 當前年
            yearItems.Add(year.ToString());
            // [List增加] 後5年
            for (int i = 1; i <= 10; i++)
            {
                yearItems.Add((year + i).ToString());
            }
            ChooseYear.DataSource = yearItems;
        }

        // [點擊年份選單內容] 改變年份
        private void ChooseYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // Debug.WriteLine("year: " + chooseYear.SelectedItem.ToString());
            //Debug.WriteLine("chooseYear: " + chooseYear.Items[chooseYear.SelectedIndex]);
            
            year = Convert.ToInt32(ChooseYear.Items[ChooseYear.SelectedIndex]);
            DaysPanel.Controls.Clear();
            DisplayDays();
            DisplayMonths();
            DisplayYears();
            //Debug.WriteLine("year: " + year);
        }

        // [點擊按鈕] 上個月
        private void LeftBtn_Click(object sender, EventArgs e)
        {
            // [清除] daysPanel
            DaysPanel.Controls.Clear();
            // [判斷] month > 12 || month < 0
            if (month > 1)
            {
                month--;
            }
            else if (month == 1)
            {
                month = 12;
                year--;
            }
            DisplayDays();
            DisplayMonths();
            DisplayYears();
        }

        // [點擊按鈕] 下個月
        private void RightBtn_Click(object sender, EventArgs e)
        {
            // [清除] daysPanel
            DaysPanel.Controls.Clear();

            // [判斷] month > 12 || month == 12
            if (month < 12)
            {
                month++;
            }
            else if (month == 12)
            {
                month = 1;
                year++;
            }
            DisplayDays();
            DisplayMonths();
            DisplayYears();
        }
    }
}
