
namespace Organizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Tasks_button = new System.Windows.Forms.Button();
            this.Calendar_button = new System.Windows.Forms.Button();
            this.Notes_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tasks_button
            // 
            this.Tasks_button.Location = new System.Drawing.Point(24, 45);
            this.Tasks_button.Name = "Tasks_button";
            this.Tasks_button.Size = new System.Drawing.Size(75, 23);
            this.Tasks_button.TabIndex = 0;
            this.Tasks_button.Text = "Tasks";
            this.Tasks_button.UseVisualStyleBackColor = true;
            this.Tasks_button.Click += new System.EventHandler(this.Tasks_button_Click);
            // 
            // Calendar_button
            // 
            this.Calendar_button.Location = new System.Drawing.Point(24, 169);
            this.Calendar_button.Name = "Calendar_button";
            this.Calendar_button.Size = new System.Drawing.Size(75, 23);
            this.Calendar_button.TabIndex = 1;
            this.Calendar_button.Text = "Calendar";
            this.Calendar_button.UseVisualStyleBackColor = true;
            this.Calendar_button.Click += new System.EventHandler(this.Calendar_button_Click);
            // 
            // Notes_button
            // 
            this.Notes_button.Location = new System.Drawing.Point(24, 294);
            this.Notes_button.Name = "Notes_button";
            this.Notes_button.Size = new System.Drawing.Size(75, 23);
            this.Notes_button.TabIndex = 2;
            this.Notes_button.Text = "Notes";
            this.Notes_button.UseVisualStyleBackColor = true;
            this.Notes_button.Click += new System.EventHandler(this.Notes_button_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Notes_button);
            this.Controls.Add(this.Calendar_button);
            this.Controls.Add(this.Tasks_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tasks_button;
        private System.Windows.Forms.Button Calendar_button;
        private System.Windows.Forms.Button Notes_button;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

