using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace TestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                var from = DateTime.Now.AddDays(-i).AddHours(i);
                var to = DateTime.Now.AddDays(i).AddHours(i);
                var item = new CalendarItem(calendar1, from, to, i  + "");

                calendar1.Items.Add(item);
            }
        }
    }
}
