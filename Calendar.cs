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
        public delegate void SelectHandler(DateTime d);
        public event SelectHandler? SelectDay;
        private DateTime selecteddate = DateTime.Now;
        private DateTime date = DateTime.Now;
        private String[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public Calendar()
        {
            InitializeComponent();
            Month_GridView.RowTemplate.Height = Month_GridView.Height/6;
            for (int i = 0; i < 6; i++)
            {
                Month_GridView.Rows.Add();
            }
            Month_GridView.Height = Month_GridView.RowTemplate.Height * 6;
            ChangeMonth();
        }
        private void ChangeMonth()
        {
            MonthName_Box.Text = Convert.ToString(date.Year) +" "+ months[date.Month - 1];
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
            Month_GridView.Rows[0].Cells[firstdate].Tag = new DateTime(date.Year, date.Month, 1);
            for (int i = 0;i<firstdate ;i++)
            {
                Month_GridView.Rows[0].Cells[firstdate - (i+1)].Value = DateTime.DaysInMonth(date.Year, date.Month == 1 ? 12:date.Month-1)-i;
                Month_GridView.Rows[0].Cells[firstdate - (i+1)].Tag = new DateTime(date.Year, date.Month == 1 ? 12 : date.Month - 1, DateTime.DaysInMonth(date.Year, date.Month == 1 ? 12 : date.Month - 1) - i);//исправить
            }
            for (int i = 1; i < 7-firstdate; i++)
            {
                Month_GridView.Rows[0].Cells[firstdate + i].Value = i + 1;
                Month_GridView.Rows[0].Cells[firstdate + i].Tag = new DateTime(date.Year, date.Month, i + 1);
            }
            int n = 8 - firstdate;
            int m = date.Month;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    d = (m == 13) ? new DateTime(date.Year + 1, 1, n):new DateTime(date.Year,m,n);
                    Month_GridView.Rows[i].Cells[j].Value = n++;
                    Month_GridView.Rows[i].Cells[j].Tag = d; 
                    if (n > DateTime.DaysInMonth(date.Year, date.Month)) { n = 1;m++; }
                }
            }

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (date.Month == 1)
            {
                date = new DateTime(date.Year - 1, 12, 31);
            }
            else
            {
                date = new DateTime(date.Year,date.Month - 1, DateTime.DaysInMonth(date.Year,date.Month-1));
            }
            ChangeMonth();
        }

        private void Forward_Button_Click(object sender, EventArgs e)
        {
            if (date.Month == 12)
            {
                date = new DateTime(date.Year + 1, 1, 1);
            }
            else
            {
                date = new DateTime(date.Year, date.Month + 1, 1);
            }
            ChangeMonth();
        }

        private void Month_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecteddate = (DateTime)Month_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;
            SelectDay.Invoke(selecteddate);
            
        }
        public DateTime SelectedDate
        {
            get { return selecteddate; }
        }
    }
}