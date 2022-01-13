
namespace Organizer
{
    partial class Tasks_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task_Panel = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Cycle_Button = new System.Windows.Forms.Button();
            this.Remind_Button = new System.Windows.Forms.Button();
            this.CompleteDate_Button = new System.Windows.Forms.Button();
            this.TaskName_Textbox = new System.Windows.Forms.TextBox();
            this.TaskNotes_Textbox = new System.Windows.Forms.TextBox();
            this.SubTasks = new System.Windows.Forms.CheckedListBox();
            this.Complete_Box = new System.Windows.Forms.CheckBox();
            this.RemindDate_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.NameTask_TextBox = new System.Windows.Forms.TextBox();
            this.AddTask_Button = new System.Windows.Forms.Button();
            this.AddButtons_Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Cycle1_Button = new System.Windows.Forms.Button();
            this.Remind1_Button = new System.Windows.Forms.Button();
            this.CompleteDate1_Button = new System.Windows.Forms.Button();
            this.Add_Panel = new System.Windows.Forms.Panel();
            this.CompleteDate_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.Tasks_GridView = new System.Windows.Forms.DataGridView();
            this.Tasks_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemindDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.CompleteDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.Groups_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Groups_GridView = new System.Windows.Forms.DataGridView();
            this.GroupName_Box = new System.Windows.Forms.TextBox();
            this.AddGroup_Button = new System.Windows.Forms.Button();
            this.Task_Panel.SuspendLayout();
            this.AddButtons_Panel.SuspendLayout();
            this.Add_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Task_Panel
            // 
            this.Task_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task_Panel.Controls.Add(this.Save);
            this.Task_Panel.Controls.Add(this.Delete_Button);
            this.Task_Panel.Controls.Add(this.Cycle_Button);
            this.Task_Panel.Controls.Add(this.Remind_Button);
            this.Task_Panel.Controls.Add(this.CompleteDate_Button);
            this.Task_Panel.Controls.Add(this.TaskName_Textbox);
            this.Task_Panel.Controls.Add(this.TaskNotes_Textbox);
            this.Task_Panel.Controls.Add(this.SubTasks);
            this.Task_Panel.Controls.Add(this.Complete_Box);
            this.Task_Panel.Location = new System.Drawing.Point(587, 2);
            this.Task_Panel.Name = "Task_Panel";
            this.Task_Panel.Size = new System.Drawing.Size(211, 441);
            this.Task_Panel.TabIndex = 7;
            this.Task_Panel.Visible = false;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(123, 381);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Button.Location = new System.Drawing.Point(147, 415);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(61, 23);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Cycle_Button
            // 
            this.Cycle_Button.Location = new System.Drawing.Point(31, 312);
            this.Cycle_Button.Name = "Cycle_Button";
            this.Cycle_Button.Size = new System.Drawing.Size(168, 23);
            this.Cycle_Button.TabIndex = 7;
            this.Cycle_Button.Text = "Повтор";
            this.Cycle_Button.UseVisualStyleBackColor = true;
            // 
            // Remind_Button
            // 
            this.Remind_Button.Location = new System.Drawing.Point(31, 283);
            this.Remind_Button.Name = "Remind_Button";
            this.Remind_Button.Size = new System.Drawing.Size(168, 23);
            this.Remind_Button.TabIndex = 6;
            this.Remind_Button.Text = "Напоминание";
            this.Remind_Button.UseVisualStyleBackColor = true;
            this.Remind_Button.Click += new System.EventHandler(this.Remind_Button_Click);
            // 
            // CompleteDate_Button
            // 
            this.CompleteDate_Button.Location = new System.Drawing.Point(31, 254);
            this.CompleteDate_Button.Name = "CompleteDate_Button";
            this.CompleteDate_Button.Size = new System.Drawing.Size(168, 23);
            this.CompleteDate_Button.TabIndex = 5;
            this.CompleteDate_Button.Text = "Дата выполнения";
            this.CompleteDate_Button.UseVisualStyleBackColor = true;
            this.CompleteDate_Button.Click += new System.EventHandler(this.CompleteDate_Button_Click);
            // 
            // TaskName_Textbox
            // 
            this.TaskName_Textbox.Location = new System.Drawing.Point(51, 20);
            this.TaskName_Textbox.Name = "TaskName_Textbox";
            this.TaskName_Textbox.Size = new System.Drawing.Size(148, 23);
            this.TaskName_Textbox.TabIndex = 3;
            this.TaskName_Textbox.TextChanged += new System.EventHandler(this.TaskName_Textbox_TextChanged);
            // 
            // TaskNotes_Textbox
            // 
            this.TaskNotes_Textbox.Location = new System.Drawing.Point(30, 129);
            this.TaskNotes_Textbox.Multiline = true;
            this.TaskNotes_Textbox.Name = "TaskNotes_Textbox";
            this.TaskNotes_Textbox.Size = new System.Drawing.Size(168, 119);
            this.TaskNotes_Textbox.TabIndex = 2;
            this.TaskNotes_Textbox.TextChanged += new System.EventHandler(this.TaskNotes_Textbox_TextChanged);
            // 
            // SubTasks
            // 
            this.SubTasks.BackColor = System.Drawing.SystemColors.Menu;
            this.SubTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubTasks.FormattingEnabled = true;
            this.SubTasks.Location = new System.Drawing.Point(31, 49);
            this.SubTasks.Name = "SubTasks";
            this.SubTasks.Size = new System.Drawing.Size(168, 74);
            this.SubTasks.TabIndex = 1;
            // 
            // Complete_Box
            // 
            this.Complete_Box.AutoSize = true;
            this.Complete_Box.Location = new System.Drawing.Point(31, 24);
            this.Complete_Box.MinimumSize = new System.Drawing.Size(10, 10);
            this.Complete_Box.Name = "Complete_Box";
            this.Complete_Box.Size = new System.Drawing.Size(15, 14);
            this.Complete_Box.TabIndex = 0;
            this.Complete_Box.UseVisualStyleBackColor = true;
            this.Complete_Box.CheckedChanged += new System.EventHandler(this.Complete_Box_CheckedChanged);
            // 
            // RemindDate_Picker1
            // 
            this.RemindDate_Picker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindDate_Picker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.RemindDate_Picker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindDate_Picker1.Location = new System.Drawing.Point(119, 0);
            this.RemindDate_Picker1.Name = "RemindDate_Picker1";
            this.RemindDate_Picker1.Size = new System.Drawing.Size(148, 23);
            this.RemindDate_Picker1.TabIndex = 12;
            this.RemindDate_Picker1.Visible = false;
            this.RemindDate_Picker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NameTask_TextBox
            // 
            this.NameTask_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTask_TextBox.Location = new System.Drawing.Point(0, 0);
            this.NameTask_TextBox.Name = "NameTask_TextBox";
            this.NameTask_TextBox.Size = new System.Drawing.Size(267, 23);
            this.NameTask_TextBox.TabIndex = 8;
            this.NameTask_TextBox.TextChanged += new System.EventHandler(this.NameTask_TextBox_TextChanged);
            // 
            // AddTask_Button
            // 
            this.AddTask_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTask_Button.Location = new System.Drawing.Point(272, 0);
            this.AddTask_Button.Name = "AddTask_Button";
            this.AddTask_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTask_Button.TabIndex = 9;
            this.AddTask_Button.Text = "Добавить";
            this.AddTask_Button.UseVisualStyleBackColor = true;
            this.AddTask_Button.Click += new System.EventHandler(this.AddTask_Button_Click);
            // 
            // AddButtons_Panel
            // 
            this.AddButtons_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButtons_Panel.Controls.Add(this.button1);
            this.AddButtons_Panel.Controls.Add(this.Cycle1_Button);
            this.AddButtons_Panel.Controls.Add(this.Remind1_Button);
            this.AddButtons_Panel.Controls.Add(this.CompleteDate1_Button);
            this.AddButtons_Panel.Location = new System.Drawing.Point(234, 412);
            this.AddButtons_Panel.Name = "AddButtons_Panel";
            this.AddButtons_Panel.Size = new System.Drawing.Size(347, 26);
            this.AddButtons_Panel.TabIndex = 10;
            this.AddButtons_Panel.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(286, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Remind1_Button.Click += new System.EventHandler(this.Remind1_Button_Click);
            // 
            // CompleteDate1_Button
            // 
            this.CompleteDate1_Button.Location = new System.Drawing.Point(0, 0);
            this.CompleteDate1_Button.Name = "CompleteDate1_Button";
            this.CompleteDate1_Button.Size = new System.Drawing.Size(112, 23);
            this.CompleteDate1_Button.TabIndex = 11;
            this.CompleteDate1_Button.Text = "Дата выполнения";
            this.CompleteDate1_Button.UseVisualStyleBackColor = true;
            this.CompleteDate1_Button.Click += new System.EventHandler(this.CompleteDate1_Button_Click);
            // 
            // Add_Panel
            // 
            this.Add_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Panel.Controls.Add(this.CompleteDate_Picker1);
            this.Add_Panel.Controls.Add(this.RemindDate_Picker1);
            this.Add_Panel.Controls.Add(this.NameTask_TextBox);
            this.Add_Panel.Controls.Add(this.AddTask_Button);
            this.Add_Panel.Location = new System.Drawing.Point(234, 384);
            this.Add_Panel.Name = "Add_Panel";
            this.Add_Panel.Size = new System.Drawing.Size(347, 25);
            this.Add_Panel.TabIndex = 11;
            this.Add_Panel.Visible = false;
            // 
            // CompleteDate_Picker1
            // 
            this.CompleteDate_Picker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteDate_Picker1.CustomFormat = "dd.MM.yyyy";
            this.CompleteDate_Picker1.Location = new System.Drawing.Point(3, 2);
            this.CompleteDate_Picker1.Name = "CompleteDate_Picker1";
            this.CompleteDate_Picker1.Size = new System.Drawing.Size(140, 23);
            this.CompleteDate_Picker1.TabIndex = 13;
            this.CompleteDate_Picker1.Visible = false;
            // 
            // Tasks_GridView
            // 
            this.Tasks_GridView.AllowUserToAddRows = false;
            this.Tasks_GridView.AllowUserToOrderColumns = true;
            this.Tasks_GridView.AllowUserToResizeColumns = false;
            this.Tasks_GridView.AllowUserToResizeRows = false;
            this.Tasks_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tasks_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tasks_GridView.ColumnHeadersVisible = false;
            this.Tasks_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tasks_Column});
            this.Tasks_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Tasks_GridView.Location = new System.Drawing.Point(234, 5);
            this.Tasks_GridView.Name = "Tasks_GridView";
            this.Tasks_GridView.RowHeadersVisible = false;
            this.Tasks_GridView.RowTemplate.Height = 25;
            this.Tasks_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tasks_GridView.Size = new System.Drawing.Size(347, 373);
            this.Tasks_GridView.TabIndex = 12;
            this.Tasks_GridView.Visible = false;
            this.Tasks_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tasks_GridView_CellContentClick);
            // 
            // Tasks_Column
            // 
            this.Tasks_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tasks_Column.HeaderText = "Column1";
            this.Tasks_Column.Name = "Tasks_Column";
            // 
            // RemindDate_Picker
            // 
            this.RemindDate_Picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemindDate_Picker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.RemindDate_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindDate_Picker.Location = new System.Drawing.Point(464, 285);
            this.RemindDate_Picker.Name = "RemindDate_Picker";
            this.RemindDate_Picker.Size = new System.Drawing.Size(148, 23);
            this.RemindDate_Picker.TabIndex = 14;
            this.RemindDate_Picker.Visible = false;
            this.RemindDate_Picker.ValueChanged += new System.EventHandler(this.RemindDate_Picker_ValueChanged);
            // 
            // CompleteDate_Picker
            // 
            this.CompleteDate_Picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteDate_Picker.CustomFormat = "dd.MM.yyyy";
            this.CompleteDate_Picker.Location = new System.Drawing.Point(472, 256);
            this.CompleteDate_Picker.Name = "CompleteDate_Picker";
            this.CompleteDate_Picker.Size = new System.Drawing.Size(140, 23);
            this.CompleteDate_Picker.TabIndex = 14;
            this.CompleteDate_Picker.Visible = false;
            this.CompleteDate_Picker.ValueChanged += new System.EventHandler(this.CompleteDate_Picker_ValueChanged);
            // 
            // Groups_Column
            // 
            this.Groups_Column.HeaderText = "Column1";
            this.Groups_Column.Name = "Groups_Column";
            this.Groups_Column.Width = 217;
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
            this.Groups_GridView.Location = new System.Drawing.Point(1, 0);
            this.Groups_GridView.Name = "Groups_GridView";
            this.Groups_GridView.RowHeadersVisible = false;
            this.Groups_GridView.RowTemplate.Height = 25;
            this.Groups_GridView.Size = new System.Drawing.Size(220, 409);
            this.Groups_GridView.TabIndex = 1;
            this.Groups_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groups_GridView_CellContentClick);
            // 
            // GroupName_Box
            // 
            this.GroupName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName_Box.Location = new System.Drawing.Point(1, 420);
            this.GroupName_Box.Name = "GroupName_Box";
            this.GroupName_Box.Size = new System.Drawing.Size(142, 23);
            this.GroupName_Box.TabIndex = 14;
            // 
            // AddGroup_Button
            // 
            this.AddGroup_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroup_Button.Location = new System.Drawing.Point(149, 420);
            this.AddGroup_Button.Name = "AddGroup_Button";
            this.AddGroup_Button.Size = new System.Drawing.Size(72, 23);
            this.AddGroup_Button.TabIndex = 14;
            this.AddGroup_Button.Text = "Добавить";
            this.AddGroup_Button.UseVisualStyleBackColor = true;
            this.AddGroup_Button.Click += new System.EventHandler(this.AddGroup_Button_Click);
            // 
            // Tasks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddGroup_Button);
            this.Controls.Add(this.GroupName_Box);
            this.Controls.Add(this.CompleteDate_Picker);
            this.Controls.Add(this.RemindDate_Picker);
            this.Controls.Add(this.Groups_GridView);
            this.Controls.Add(this.Add_Panel);
            this.Controls.Add(this.AddButtons_Panel);
            this.Controls.Add(this.Task_Panel);
            this.Controls.Add(this.Tasks_GridView);
            this.Name = "Tasks_Form";
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Task_Panel.ResumeLayout(false);
            this.Task_Panel.PerformLayout();
            this.AddButtons_Panel.ResumeLayout(false);
            this.Add_Panel.ResumeLayout(false);
            this.Add_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Task_Panel;
        private System.Windows.Forms.CheckedListBox SubTasks;
        private System.Windows.Forms.CheckBox Complete_Box;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Cycle_Button;
        private System.Windows.Forms.Button Remind_Button;
        private System.Windows.Forms.Button CompleteDate_Button;
        private System.Windows.Forms.TextBox TaskName_Textbox;
        private System.Windows.Forms.TextBox TaskNotes_Textbox;
        private System.Windows.Forms.TextBox NameTask_TextBox;
        private System.Windows.Forms.Button AddTask_Button;
        private System.Windows.Forms.Panel AddButtons_Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cycle1_Button;
        private System.Windows.Forms.Button Remind1_Button;
        private System.Windows.Forms.Button CompleteDate1_Button;
        private System.Windows.Forms.Panel Add_Panel;
        private System.Windows.Forms.DataGridViewButtonColumn Groups;
        private System.Windows.Forms.DataGridView Tasks_GridView;
        private System.Windows.Forms.DateTimePicker RemindDate_Picker1;
        private System.Windows.Forms.DateTimePicker CompleteDate_Picker1;
        private System.Windows.Forms.DateTimePicker RemindDate_Picker;
        private System.Windows.Forms.DateTimePicker CompleteDate_Picker;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewButtonColumn Groups_Column;
        private System.Windows.Forms.DataGridView Groups_GridView;
        private System.Windows.Forms.DataGridViewButtonColumn Tasks_Column;
        private System.Windows.Forms.TextBox GroupName_Box;
        private System.Windows.Forms.Button AddGroup_Button;
    }
}

