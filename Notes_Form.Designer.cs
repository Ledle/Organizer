namespace Organizer
{
    partial class Notes_Form
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
            this.Note_TextBox = new System.Windows.Forms.TextBox();
            this.AddNote_Button = new System.Windows.Forms.Button();
            this.Notes_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Files_Button = new System.Windows.Forms.Button();
            this.AddGroup_Button = new System.Windows.Forms.Button();
            this.GroupName_Box = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Note_Panel = new System.Windows.Forms.Panel();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes_GridView)).BeginInit();
            this.Note_Panel.SuspendLayout();
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
            this.Groups_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Groups_GridView.Size = new System.Drawing.Size(150, 415);
            this.Groups_GridView.TabIndex = 2;
            this.Groups_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groups_GridView_CellContentClick);
            // 
            // Groups_Column
            // 
            this.Groups_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Groups_Column.HeaderText = "Column1";
            this.Groups_Column.Name = "Groups_Column";
            // 
            // Note_TextBox
            // 
            this.Note_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_TextBox.Location = new System.Drawing.Point(0, 0);
            this.Note_TextBox.Multiline = true;
            this.Note_TextBox.Name = "Note_TextBox";
            this.Note_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Note_TextBox.Size = new System.Drawing.Size(474, 415);
            this.Note_TextBox.TabIndex = 14;
            this.Note_TextBox.TextChanged += new System.EventHandler(this.Note_TextBox_TextChanged);
            // 
            // AddNote_Button
            // 
            this.AddNote_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNote_Button.Location = new System.Drawing.Point(399, 414);
            this.AddNote_Button.Name = "AddNote_Button";
            this.AddNote_Button.Size = new System.Drawing.Size(75, 37);
            this.AddNote_Button.TabIndex = 15;
            this.AddNote_Button.Text = "Готово";
            this.AddNote_Button.UseVisualStyleBackColor = true;
            this.AddNote_Button.Click += new System.EventHandler(this.AddNote_Button_Click);
            // 
            // Notes_GridView
            // 
            this.Notes_GridView.AllowUserToAddRows = false;
            this.Notes_GridView.AllowUserToOrderColumns = true;
            this.Notes_GridView.AllowUserToResizeColumns = false;
            this.Notes_GridView.AllowUserToResizeRows = false;
            this.Notes_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Notes_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes_GridView.ColumnHeadersVisible = false;
            this.Notes_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.Notes_GridView.Location = new System.Drawing.Point(156, 0);
            this.Notes_GridView.Name = "Notes_GridView";
            this.Notes_GridView.RowHeadersVisible = false;
            this.Notes_GridView.RowTemplate.Height = 25;
            this.Notes_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Notes_GridView.Size = new System.Drawing.Size(163, 415);
            this.Notes_GridView.TabIndex = 16;
            this.Notes_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Notes_GridView_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.HeaderText = "Column1";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // Files_Button
            // 
            this.Files_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Files_Button.Location = new System.Drawing.Point(318, 414);
            this.Files_Button.Name = "Files_Button";
            this.Files_Button.Size = new System.Drawing.Size(75, 37);
            this.Files_Button.TabIndex = 17;
            this.Files_Button.Text = "Файлы";
            this.Files_Button.UseVisualStyleBackColor = true;
            // 
            // AddGroup_Button
            // 
            this.AddGroup_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroup_Button.Location = new System.Drawing.Point(156, 421);
            this.AddGroup_Button.Name = "AddGroup_Button";
            this.AddGroup_Button.Size = new System.Drawing.Size(71, 23);
            this.AddGroup_Button.TabIndex = 18;
            this.AddGroup_Button.Text = "Добавить";
            this.AddGroup_Button.UseVisualStyleBackColor = true;
            this.AddGroup_Button.Click += new System.EventHandler(this.AddGroup_Button_Click);
            // 
            // GroupName_Box
            // 
            this.GroupName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName_Box.Location = new System.Drawing.Point(0, 421);
            this.GroupName_Box.Name = "GroupName_Box";
            this.GroupName_Box.Size = new System.Drawing.Size(150, 23);
            this.GroupName_Box.TabIndex = 19;
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(237, 414);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 37);
            this.Save_Button.TabIndex = 20;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Note_Panel
            // 
            this.Note_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Panel.Controls.Add(this.Delete_Button);
            this.Note_Panel.Controls.Add(this.Note_TextBox);
            this.Note_Panel.Controls.Add(this.Save_Button);
            this.Note_Panel.Controls.Add(this.Files_Button);
            this.Note_Panel.Controls.Add(this.AddNote_Button);
            this.Note_Panel.Location = new System.Drawing.Point(325, 0);
            this.Note_Panel.Name = "Note_Panel";
            this.Note_Panel.Size = new System.Drawing.Size(474, 454);
            this.Note_Panel.TabIndex = 21;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Button.Location = new System.Drawing.Point(156, 414);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 37);
            this.Delete_Button.TabIndex = 21;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Visible = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Notes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Note_Panel);
            this.Controls.Add(this.AddGroup_Button);
            this.Controls.Add(this.GroupName_Box);
            this.Controls.Add(this.Notes_GridView);
            this.Controls.Add(this.Groups_GridView);
            this.Name = "Notes_Form";
            this.Text = "Notes_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Groups_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes_GridView)).EndInit();
            this.Note_Panel.ResumeLayout(false);
            this.Note_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Groups_GridView;
        private System.Windows.Forms.TextBox Note_TextBox;
        private System.Windows.Forms.Button AddNote_Button;
        private System.Windows.Forms.DataGridView Notes_GridView;
        private System.Windows.Forms.Button Files_Button;
        private System.Windows.Forms.Button AddGroup_Button;
        private System.Windows.Forms.TextBox GroupName_Box;
        private System.Windows.Forms.DataGridViewButtonColumn Groups_Column;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Panel Note_Panel;
        private System.Windows.Forms.Button Delete_Button;
    }
}