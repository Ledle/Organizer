using System;
namespace Organizer
{
    partial class Calendar
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Month_GridView = new System.Windows.Forms.DataGridView();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.MonthName_Box = new System.Windows.Forms.TextBox();
            this.Monday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Friday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Month_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Month_GridView
            // 
            this.Month_GridView.AllowUserToAddRows = false;
            this.Month_GridView.AllowUserToResizeRows = false;
            this.Month_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Month_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Month_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.Month_GridView.Location = new System.Drawing.Point(0, 26);
            this.Month_GridView.Margin = new System.Windows.Forms.Padding(0);
            this.Month_GridView.Name = "Month_GridView";
            this.Month_GridView.RowHeadersVisible = false;
            this.Month_GridView.RowHeadersWidth = 50;
            this.Month_GridView.RowTemplate.Height = 50;
            this.Month_GridView.Size = new System.Drawing.Size(683, 382);
            this.Month_GridView.TabIndex = 0;
            this.Month_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Month_GridView_CellContentClick);
            this.Month_GridView.Resize += new System.EventHandler(this.Month_GridView_Resize);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(165, 0);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 1;
            this.Back_Button.Text = "<";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Forward_Button
            // 
            this.Forward_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Forward_Button.Location = new System.Drawing.Point(400, 0);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(75, 23);
            this.Forward_Button.TabIndex = 2;
            this.Forward_Button.Text = ">";
            this.Forward_Button.UseVisualStyleBackColor = true;
            this.Forward_Button.Click += new System.EventHandler(this.Forward_Button_Click);
            // 
            // MonthName_Box
            // 
            this.MonthName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthName_Box.Location = new System.Drawing.Point(246, 0);
            this.MonthName_Box.Name = "MonthName_Box";
            this.MonthName_Box.ReadOnly = true;
            this.MonthName_Box.Size = new System.Drawing.Size(148, 23);
            this.MonthName_Box.TabIndex = 3;
            this.MonthName_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Monday
            // 
            this.Monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Monday.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monday.HeaderText = "Понедельник";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tuesday.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Wednesday.DefaultCellStyle = dataGridViewCellStyle3;
            this.Wednesday.HeaderText = "Среда";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Thursday.DefaultCellStyle = dataGridViewCellStyle4;
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.DefaultCellStyle = dataGridViewCellStyle5;
            this.Friday.HeaderText = "Пятница";
            this.Friday.Name = "Friday";
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saturday
            // 
            this.Saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.DefaultCellStyle = dataGridViewCellStyle6;
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.Name = "Saturday";
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sunday
            // 
            this.Sunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sunday.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sunday.HeaderText = "Воскресенье";
            this.Sunday.Name = "Sunday";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MonthName_Box);
            this.Controls.Add(this.Forward_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Month_GridView);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(683, 408);
            ((System.ComponentModel.ISupportInitialize)(this.Month_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Month_GridView;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.TextBox MonthName_Box;
        private System.Windows.Forms.DataGridViewButtonColumn Monday;
        private System.Windows.Forms.DataGridViewButtonColumn Tuesday;
        private System.Windows.Forms.DataGridViewButtonColumn Wednesday;
        private System.Windows.Forms.DataGridViewButtonColumn Thursday;
        private System.Windows.Forms.DataGridViewButtonColumn Friday;
        private System.Windows.Forms.DataGridViewButtonColumn Saturday;
        private System.Windows.Forms.DataGridViewButtonColumn Sunday;
    }
}
