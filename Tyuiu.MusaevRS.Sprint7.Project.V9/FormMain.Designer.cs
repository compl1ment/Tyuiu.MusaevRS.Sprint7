
namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    partial class FormMain
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
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.Controls.Add(this.ButtonFilter);
            this.groupBoxMain.Controls.Add(this.buttonOpen);
            this.groupBoxMain.Controls.Add(this.textBoxFile);
            this.groupBoxMain.Controls.Add(this.textBox1);
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(207, 425);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильтрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFilter.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.folder_edit;
            this.ButtonFilter.Location = new System.Drawing.Point(6, 130);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(95, 44);
            this.ButtonFilter.TabIndex = 2;
            this.ButtonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpen.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.folder_page;
            this.buttonOpen.Location = new System.Drawing.Point(49, 41);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(98, 48);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile.Location = new System.Drawing.Point(44, 94);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(111, 17);
            this.textBoxFile.TabIndex = 0;
            this.textBoxFile.Text = "Обработка файла:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(15, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Выберите файл для обработки";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.ColumnHeadersVisible = false;
            this.dataGridViewMain.Location = new System.Drawing.Point(225, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewMain.Size = new System.Drawing.Size(546, 425);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 449);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.groupBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Sprint 7 | MusaevRS | Project | V9";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}

