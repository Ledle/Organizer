﻿using System;
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
            this.Month_GridView = new System.Windows.Forms.DataGridView();
            this.Monday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Friday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.MonthName_Box = new System.Windows.Forms.TextBox();
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
            // 
            // Monday
            // 
            this.Monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monday.HeaderText = "Понедельник";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wednesday.HeaderText = "Среда";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Friday.HeaderText = "Пятница";
            this.Friday.Name = "Friday";
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saturday
            // 
            this.Saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.Name = "Saturday";
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sunday
            // 
            this.Sunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sunday.HeaderText = "Воскресенье";
            this.Sunday.Name = "Sunday";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(213, 0);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 1;
            this.Back_Button.Text = "<";
            this.Back_Button.UseVisualStyleBackColor = true;
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
            // 
            // MonthName_Box
            // 
            this.MonthName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthName_Box.Location = new System.Drawing.Point(294, 0);
            this.MonthName_Box.Name = "MonthName_Box";
            this.MonthName_Box.ReadOnly = true;
            this.MonthName_Box.Size = new System.Drawing.Size(100, 23);
            this.MonthName_Box.TabIndex = 3;
            this.MonthName_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.DataGridViewButtonColumn Monday;
        private System.Windows.Forms.DataGridViewButtonColumn Tuesday;
        private System.Windows.Forms.DataGridViewButtonColumn Wednesday;
        private System.Windows.Forms.DataGridViewButtonColumn Thursday;
        private System.Windows.Forms.DataGridViewButtonColumn Friday;
        private System.Windows.Forms.DataGridViewButtonColumn Saturday;
        private System.Windows.Forms.DataGridViewButtonColumn Sunday;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.TextBox MonthName_Box;
    }
}
