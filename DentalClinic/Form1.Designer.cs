using System.Drawing;

namespace DentalClinic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.PatientsList = new System.Windows.Forms.Button();
            this.IDs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SeaShell;
            this.Add.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add.Location = new System.Drawing.Point(42, 286);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 28);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.SeaShell;
            this.Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search.Location = new System.Drawing.Point(42, 337);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 28);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.SeaShell;
            this.Edit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Edit.Location = new System.Drawing.Point(42, 385);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(112, 28);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // PatientsList
            // 
            this.PatientsList.BackColor = System.Drawing.Color.SeaShell;
            this.PatientsList.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PatientsList.Location = new System.Drawing.Point(42, 436);
            this.PatientsList.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsList.Name = "PatientsList";
            this.PatientsList.Size = new System.Drawing.Size(112, 28);
            this.PatientsList.TabIndex = 4;
            this.PatientsList.Text = "Patients List";
            this.PatientsList.UseVisualStyleBackColor = false;
            this.PatientsList.Click += new System.EventHandler(this.PatientsList_Click);
            // 
            // IDs
            // 
            this.IDs.BackColor = System.Drawing.Color.SeaShell;
            this.IDs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IDs.Location = new System.Drawing.Point(42, 481);
            this.IDs.Margin = new System.Windows.Forms.Padding(4);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(112, 28);
            this.IDs.TabIndex = 5;
            this.IDs.Text = "IDs";
            this.IDs.UseVisualStyleBackColor = false;
            this.IDs.Click += new System.EventHandler(this.IDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 854);
            this.Controls.Add(this.IDs);
            this.Controls.Add(this.PatientsList);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Dental Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button PatientsList;
        private System.Windows.Forms.Button IDs;
    }
}

namespace DentalClinic.Properties
{
}