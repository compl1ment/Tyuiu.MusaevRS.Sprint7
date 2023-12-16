
namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    partial class FormOpen
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
            this.labelFileOpen = new System.Windows.Forms.Label();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileOpen
            // 
            this.labelFileOpen.AutoSize = true;
            this.labelFileOpen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileOpen.Location = new System.Drawing.Point(64, 55);
            this.labelFileOpen.Name = "labelFileOpen";
            this.labelFileOpen.Size = new System.Drawing.Size(298, 30);
            this.labelFileOpen.TabIndex = 1;
            this.labelFileOpen.Text = "Выберите файл формата csv  ";
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenFile.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.folder_table;
            this.buttonOpenFile.Location = new System.Drawing.Point(0, 94);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(424, 72);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 166);
            this.Controls.Add(this.labelFileOpen);
            this.Controls.Add(this.buttonOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOpen";
            this.Text = "Sprint 7 | MusaevRS | Project | V9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
    }
}