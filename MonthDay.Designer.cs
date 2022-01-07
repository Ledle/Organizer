namespace Organizer
{
    partial class MonthDay
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
            this.WeekDay_Label = new System.Windows.Forms.Label();
            this.Day_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeekDay_Label
            // 
            this.WeekDay_Label.AutoSize = true;
            this.WeekDay_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDay_Label.Location = new System.Drawing.Point(4, 0);
            this.WeekDay_Label.Name = "WeekDay_Label";
            this.WeekDay_Label.Size = new System.Drawing.Size(75, 21);
            this.WeekDay_Label.TabIndex = 0;
            this.WeekDay_Label.Text = "WeekDay";
            // 
            // Day_Label
            // 
            this.Day_Label.AutoSize = true;
            this.Day_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Day_Label.Location = new System.Drawing.Point(22, 39);
            this.Day_Label.Name = "Day_Label";
            this.Day_Label.Size = new System.Drawing.Size(37, 21);
            this.Day_Label.TabIndex = 1;
            this.Day_Label.Text = "Day";
            // 
            // MonthDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Day_Label);
            this.Controls.Add(this.WeekDay_Label);
            this.Name = "MonthDay";
            this.Size = new System.Drawing.Size(82, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekDay_Label;
        private System.Windows.Forms.Label Day_Label;

        public System.Windows.Forms.Label WeekDay
        {
            get { return this.WeekDay_Label; }
            set { this.WeekDay_Label = value; }
        }
        public System.Windows.Forms.Label Day
        {
            get { return this.Day_Label; }
            set { this.Day_Label = value; }
        }
        
    }
}
