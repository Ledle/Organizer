namespace Organizer
{
    partial class Calendar_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Groups_GridView = new System.Windows.Forms.DataGridView();
            this.Groups_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Events_GridView = new System.Windows.Forms.DataGridView();
            this.Tasks_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Task_Panel = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Cycle_Button = new System.Windows.Forms.Button();
            this.Remind_Button = new System.Windows.Forms.Button();
            this.CompleteDate_Button = new System.Windows.Forms.Button();
            this.TaskName_Textbox = new System.Windows.Forms.TextBox();
            this.TaskNotes_Textbox = new System.Windows.Forms.TextBox();
            this.Complete_Box = new System.Windows.Forms.CheckBox();
            this.Add_Panel = new System.Windows.Forms.Panel();
            this.CompleteDate_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.RemindDate_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.NameTask_TextBox = new System.Windows.Forms.TextBox();
            this.AddButtons_Panel = new System.Windows.Forms.Panel();
            this.Cycle1_Button = new System.Windows.Forms.Button();
            this.Remind1_Button = new System.Windows.Forms.Button();
            this.CompleteDate1_Button = new System.Windows.Forms.Button();
            this.MonthCalendar = new Organizer.Calendar();
            this.AddGroup_Button = new System.Windows.Forms.Button();
            this.GroupName_Box = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Events_GridView)).BeginInit();
            this.Task_Panel.SuspendLayout();
            this.Add_Panel.SuspendLayout();
            this.AddButtons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groups_GridView
            // 
            this.Groups_GridView.AllowUserToAddRows = false;
            this.Groups_GridView.AllowUserToOrderColumns = true;
            this.Groups_GridView.AllowUserToResizeColumns = false;
            this.Groups_GridView.AllowUserToResizeRows = false;
            this.Groups_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Groups_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groups_GridView.ColumnHeadersVisible = false;
            this.Groups_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groups_Column});
            this.Groups_GridView.Location = new System.Drawing.Point(0, 0);
            this.Groups_GridView.Name = "Groups_GridView";
            this.Groups_GridView.RowHeadersVisible = false;
            this.Groups_GridView.RowTemplate.Height = 25;
            this.Groups_GridView.Size = new System.Drawing.Size(233, 455);
            this.Groups_GridView.TabIndex = 2;
            this.Groups_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groups_GridView_CellContentClick);
            // 
            // Groups_Column
            // 
            this.Groups_Column.HeaderText = "Column1";
            this.Groups_Column.Name = "Groups_Column";
            this.Groups_Column.Width = 217;
            // 
            // Events_GridView
            // 
            this.Events_GridView.AllowUserToAddRows = false;
            this.Events_GridView.AllowUserToOrderColumns = true;
            this.Events_GridView.AllowUserToResizeColumns = false;
            this.Events_GridView.AllowUserToResizeRows = false;
            this.Events_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Events_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Events_GridView.ColumnHeadersVisible = false;
            this.Events_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tasks_Column});
            this.Events_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Events_GridView.Location = new System.Drawing.Point(873, 0);
            this.Events_GridView.Name = "Events_GridView";
            this.Events_GridView.RowHeadersVisible = false;
            this.Events_GridView.RowTemplate.Height = 25;
            this.Events_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Events_GridView.Size = new System.Drawing.Size(211, 199);
            this.Events_GridView.TabIndex = 13;
            this.Events_GridView.Visible = false;
            // 
            // Tasks_Column
            // 
            this.Tasks_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tasks_Column.HeaderText = "Column1";
            this.Tasks_Column.Name = "Tasks_Column";
            // 
            // Task_Panel
            // 
            this.Task_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task_Panel.Controls.Add(this.Save_Button);
            this.Task_Panel.Controls.Add(this.Save);
            this.Task_Panel.Controls.Add(this.Delete_Button);
            this.Task_Panel.Controls.Add(this.Cycle_Button);
            this.Task_Panel.Controls.Add(this.Remind_Button);
            this.Task_Panel.Controls.Add(this.CompleteDate_Button);
            this.Task_Panel.Controls.Add(this.TaskName_Textbox);
            this.Task_Panel.Controls.Add(this.TaskNotes_Textbox);
            this.Task_Panel.Controls.Add(this.Complete_Box);
            this.Task_Panel.Location = new System.Drawing.Point(873, 198);
            this.Task_Panel.Name = "Task_Panel";
            this.Task_Panel.Size = new System.Drawing.Size(211, 288);
            this.Task_Panel.TabIndex = 14;
            this.Task_Panel.Visible = false;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(134, 569);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Button.Location = new System.Drawing.Point(148, 606);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(61, 23);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Cycle_Button
            // 
            this.Cycle_Button.Location = new System.Drawing.Point(30, 215);
            this.Cycle_Button.Name = "Cycle_Button";
            this.Cycle_Button.Size = new System.Drawing.Size(168, 23);
            this.Cycle_Button.TabIndex = 7;
            this.Cycle_Button.Text = "Повтор";
            this.Cycle_Button.UseVisualStyleBackColor = true;
            // 
            // Remind_Button
            // 
            this.Remind_Button.Location = new System.Drawing.Point(32, 186);
            this.Remind_Button.Name = "Remind_Button";
            this.Remind_Button.Size = new System.Drawing.Size(168, 23);
            this.Remind_Button.TabIndex = 6;
            this.Remind_Button.Text = "Напоминание";
            this.Remind_Button.UseVisualStyleBackColor = true;
            // 
            // CompleteDate_Button
            // 
            this.CompleteDate_Button.Location = new System.Drawing.Point(30, 157);
            this.CompleteDate_Button.Name = "CompleteDate_Button";
            this.CompleteDate_Button.Size = new System.Drawing.Size(168, 23);
            this.CompleteDate_Button.TabIndex = 5;
            this.CompleteDate_Button.Text = "Дата выполнения";
            this.CompleteDate_Button.UseVisualStyleBackColor = true;
            // 
            // TaskName_Textbox
            // 
            this.TaskName_Textbox.Location = new System.Drawing.Point(52, 3);
            this.TaskName_Textbox.Name = "TaskName_Textbox";
            this.TaskName_Textbox.Size = new System.Drawing.Size(148, 23);
            this.TaskName_Textbox.TabIndex = 3;
            // 
            // TaskNotes_Textbox
            // 
            this.TaskNotes_Textbox.Location = new System.Drawing.Point(31, 32);
            this.TaskNotes_Textbox.Multiline = true;
            this.TaskNotes_Textbox.Name = "TaskNotes_Textbox";
            this.TaskNotes_Textbox.Size = new System.Drawing.Size(168, 119);
            this.TaskNotes_Textbox.TabIndex = 2;
            // 
            // Complete_Box
            // 
            this.Complete_Box.AutoSize = true;
            this.Complete_Box.Location = new System.Drawing.Point(31, 7);
            this.Complete_Box.MinimumSize = new System.Drawing.Size(10, 10);
            this.Complete_Box.Name = "Complete_Box";
            this.Complete_Box.Size = new System.Drawing.Size(15, 14);
            this.Complete_Box.TabIndex = 0;
            this.Complete_Box.UseVisualStyleBackColor = true;
            // 
            // Add_Panel
            // 
            this.Add_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Panel.Controls.Add(this.CompleteDate_Picker1);
            this.Add_Panel.Controls.Add(this.RemindDate_Picker1);
            this.Add_Panel.Controls.Add(this.NameTask_TextBox);
            this.Add_Panel.Location = new System.Drawing.Point(240, 432);
            this.Add_Panel.Name = "Add_Panel";
            this.Add_Panel.Size = new System.Drawing.Size(627, 25);
            this.Add_Panel.TabIndex = 16;
            this.Add_Panel.Visible = false;
            // 
            // CompleteDate_Picker1
            // 
            this.CompleteDate_Picker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteDate_Picker1.CustomFormat = "dd.MM.yyyy";
            this.CompleteDate_Picker1.Location = new System.Drawing.Point(3, 2);
            this.CompleteDate_Picker1.Name = "CompleteDate_Picker1";
            this.CompleteDate_Picker1.Size = new System.Drawing.Size(567, 23);
            this.CompleteDate_Picker1.TabIndex = 13;
            this.CompleteDate_Picker1.Visible = false;
            // 
            // RemindDate_Picker1
            // 
            this.RemindDate_Picker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindDate_Picker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.RemindDate_Picker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindDate_Picker1.Location = new System.Drawing.Point(119, 0);
            this.RemindDate_Picker1.Name = "RemindDate_Picker1";
            this.RemindDate_Picker1.Size = new System.Drawing.Size(508, 23);
            this.RemindDate_Picker1.TabIndex = 12;
            this.RemindDate_Picker1.Visible = false;
            // 
            // NameTask_TextBox
            // 
            this.NameTask_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTask_TextBox.Location = new System.Drawing.Point(0, 0);
            this.NameTask_TextBox.Name = "NameTask_TextBox";
            this.NameTask_TextBox.Size = new System.Drawing.Size(694, 23);
            this.NameTask_TextBox.TabIndex = 8;
            // 
            // AddButtons_Panel
            // 
            this.AddButtons_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButtons_Panel.Controls.Add(this.Cycle1_Button);
            this.AddButtons_Panel.Controls.Add(this.Remind1_Button);
            this.AddButtons_Panel.Controls.Add(this.CompleteDate1_Button);
            this.AddButtons_Panel.Location = new System.Drawing.Point(240, 460);
            this.AddButtons_Panel.Name = "AddButtons_Panel";
            this.AddButtons_Panel.Size = new System.Drawing.Size(627, 26);
            this.AddButtons_Panel.TabIndex = 15;
            this.AddButtons_Panel.Visible = false;
            // 
            // Cycle1_Button
            // 
            this.Cycle1_Button.Location = new System.Drawing.Point(224, 0);
            this.Cycle1_Button.Name = "Cycle1_Button";
            this.Cycle1_Button.Size = new System.Drawing.Size(58, 23);
            this.Cycle1_Button.TabIndex = 9;
            this.Cycle1_Button.Text = "Повтор";
            this.Cycle1_Button.UseVisualStyleBackColor = true;
            // 
            // Remind1_Button
            // 
            this.Remind1_Button.Location = new System.Drawing.Point(115, 0);
            this.Remind1_Button.Name = "Remind1_Button";
            this.Remind1_Button.Size = new System.Drawing.Size(106, 23);
            this.Remind1_Button.TabIndex = 9;
            this.Remind1_Button.Text = "Напоминание";
            this.Remind1_Button.UseVisualStyleBackColor = true;
            // 
            // CompleteDate1_Button
            // 
            this.CompleteDate1_Button.Location = new System.Drawing.Point(0, 0);
            this.CompleteDate1_Button.Name = "CompleteDate1_Button";
            this.CompleteDate1_Button.Size = new System.Drawing.Size(112, 23);
            this.CompleteDate1_Button.TabIndex = 11;
            this.CompleteDate1_Button.Text = "Дата выполнения";
            this.CompleteDate1_Button.UseVisualStyleBackColor = true;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(239, 1);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.Size = new System.Drawing.Size(628, 435);
            this.MonthCalendar.TabIndex = 17;
            // 
            // AddGroup_Button
            // 
            this.AddGroup_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroup_Button.Location = new System.Drawing.Point(162, 463);
            this.AddGroup_Button.Name = "AddGroup_Button";
            this.AddGroup_Button.Size = new System.Drawing.Size(72, 23);
            this.AddGroup_Button.TabIndex = 18;
            this.AddGroup_Button.Text = "Добавить";
            this.AddGroup_Button.UseVisualStyleBackColor = true;
            this.AddGroup_Button.Click += new System.EventHandler(this.AddGroup_Button_Click);
            // 
            // GroupName_Box
            // 
            this.GroupName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName_Box.Location = new System.Drawing.Point(0, 463);
            this.GroupName_Box.Name = "GroupName_Box";
            this.GroupName_Box.Size = new System.Drawing.Size(156, 23);
            this.GroupName_Box.TabIndex = 19;
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(80, 247);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 20;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Calendar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 490);
            this.Controls.Add(this.AddGroup_Button);
            this.Controls.Add(this.GroupName_Box);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.Add_Panel);
            this.Controls.Add(this.AddButtons_Panel);
            this.Controls.Add(this.Groups_GridView);
            this.Controls.Add(this.Task_Panel);
            this.Controls.Add(this.Events_GridView);
            this.MinimumSize = new System.Drawing.Size(1099, 529);
            this.Name = "Calendar_Form";
            this.Text = "Calendar_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Events_GridView)).EndInit();
            this.Task_Panel.ResumeLayout(false);
            this.Task_Panel.PerformLayout();
            this.Add_Panel.ResumeLayout(false);
            this.Add_Panel.PerformLayout();
            this.AddButtons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Groups_GridView;
        private System.Windows.Forms.DataGridViewButtonColumn Groups_Column;
        private System.Windows.Forms.DataGridView Events_GridView;
        private System.Windows.Forms.DataGridViewButtonColumn Tasks_Column;
        private System.Windows.Forms.Panel Task_Panel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Cycle_Button;
        private System.Windows.Forms.Button Remind_Button;
        private System.Windows.Forms.Button CompleteDate_Button;
        private System.Windows.Forms.TextBox TaskName_Textbox;
        private System.Windows.Forms.TextBox TaskNotes_Textbox;
        private System.Windows.Forms.CheckBox Complete_Box;
        private System.Windows.Forms.Panel Add_Panel;
        private System.Windows.Forms.DateTimePicker CompleteDate_Picker1;
        private System.Windows.Forms.DateTimePicker RemindDate_Picker1;
        private System.Windows.Forms.TextBox NameTask_TextBox;
        private System.Windows.Forms.Panel AddButtons_Panel;
        private System.Windows.Forms.Button Cycle1_Button;
        private System.Windows.Forms.Button Remind1_Button;
        private System.Windows.Forms.Button CompleteDate1_Button;
        private Calendar MonthCalendar;
        private System.Windows.Forms.Button AddGroup_Button;
        private System.Windows.Forms.TextBox GroupName_Box;
        private System.Windows.Forms.Button Save_Button;
    }
}