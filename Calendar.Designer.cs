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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Monday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Friday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(704, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Понедельник";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Среда";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Пятница";
            this.Friday.Name = "Friday";
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.Name = "Saturday";
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Воскресенье";
            this.Sunday.Name = "Sunday";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(710, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Monday;
        private System.Windows.Forms.DataGridViewButtonColumn Tuesday;
        private System.Windows.Forms.DataGridViewButtonColumn Wednesday;
        private System.Windows.Forms.DataGridViewButtonColumn Thursday;
        private System.Windows.Forms.DataGridViewButtonColumn Friday;
        private System.Windows.Forms.DataGridViewButtonColumn Saturday;
        private System.Windows.Forms.DataGridViewButtonColumn Sunday;
    }
}
