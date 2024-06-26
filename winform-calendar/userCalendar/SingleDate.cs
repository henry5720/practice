using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using userCalendar;
using userCalendar.Properties;

namespace WinFormsApp1
{
    public partial class SingleDate : UserControl
    {
        public SingleDate()
        {
            InitializeComponent();
        }

        // [修改文字]
        public void days(int numDay)
        {
            daysBtn.Text = numDay+"";
        }

        // [今天顏色]
        public void todayColor()
        {
            Image picture;
            picture = new Bitmap(Resources.todayColor); 
            this.daysBtn.BackgroundImage = picture;
        }
    }
}
