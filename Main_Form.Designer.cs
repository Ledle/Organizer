namespace Organizer
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tray_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tasks_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calendar_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notes_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tray_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.Tray_contextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Органайзер";
            this.TrayIcon.Visible = true;
            // 
            // Tray_contextMenu
            // 
            this.Tray_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tasks_MenuItem,
            this.Calendar_MenuItem,
            this.Notes_MenuItem,
            this.Exit_MenuItem});
            this.Tray_contextMenu.Name = "Tray_contextMenu";
            this.Tray_contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Tray_contextMenu.Size = new System.Drawing.Size(133, 92);
            // 
            // Tasks_MenuItem
            // 
            this.Tasks_MenuItem.Name = "Tasks_MenuItem";
            this.Tasks_MenuItem.Size = new System.Drawing.Size(132, 22);
            this.Tasks_MenuItem.Text = "Задачи";
            this.Tasks_MenuItem.Click += new System.EventHandler(this.Tasks_MenuItem_Click);
            // 
            // Calendar_MenuItem
            // 
            this.Calendar_MenuItem.Name = "Calendar_MenuItem";
            this.Calendar_MenuItem.Size = new System.Drawing.Size(132, 22);
            this.Calendar_MenuItem.Text = "Календарь";
            // 
            // Notes_MenuItem
            // 
            this.Notes_MenuItem.Name = "Notes_MenuItem";
            this.Notes_MenuItem.Size = new System.Drawing.Size(132, 22);
            this.Notes_MenuItem.Text = "Заметки";
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Size = new System.Drawing.Size(132, 22);
            this.Exit_MenuItem.Text = "Выход";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.Tray_contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip Tray_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem Tasks_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Calendar_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Notes_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
    }
}