using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Calendar : UserControl
    {
        private DateTime date = DateTime.Now;
        private String[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public Calendar()
        {
            InitializeComponent();
            Month_GridView.RowTemplate.Height = Month_GridView.Height/5;
            for (int i = 0; i < 5; i++)
            {
                Month_GridView.Rows.Add();
            }
            Month_GridView.Height = Month_GridView.RowTemplate.Height * 5;
            ChangeMonth();
        }
        private void ChangeMonth()
        {
            MonthName_Box.Text = months[date.Month - 1];
            int firstdate=-1;
            DateTime d = new DateTime(date.Year, date.Month, 1);
            switch (d.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    firstdate = 0;
                    break;
                case DayOfWeek.Tuesday:
                    firstdate = 1;
                    break;
                case DayOfWeek.Wednesday:
                    firstdate = 2;
                    break;
                case DayOfWeek.Thursday:
                    firstdate = 3;
                    break;
                case DayOfWeek.Friday:
                    firstdate = 4;
                    break;
                case DayOfWeek.Saturday:
                    firstdate = 5;
                    break;
                case DayOfWeek.Sunday:
                    firstdate = 6;
                    break;
            }
            Month_GridView.Rows[0].Cells[firstdate].Value = 1;
            for (int i = 0;i<firstdate ;i++)
            {
                Month_GridView.Rows[0].Cells[firstdate - (i+1)].Value = DateTime.DaysInMonth(date.Year, date.Month)-i;
            }
            for (int i = 1; i < 7-firstdate; i++)
            {
                Month_GridView.Rows[0].Cells[firstdate + i].Value = i + 1;
            }
        }
    }
}