
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonOpenFile);
            this.groupBoxMain.Controls.Add(this.buttonSave);
            this.groupBoxMain.Controls.Add(this.buttonSearch);
            this.groupBoxMain.Controls.Add(this.buttonSort);
            this.groupBoxMain.Controls.Add(this.ButtonFilter);
            this.groupBoxMain.Controls.Add(this.textBoxSave);
            this.groupBoxMain.Controls.Add(this.textBoxSearch);
            this.groupBoxMain.Controls.Add(this.textBoxSort);
            this.groupBoxMain.Controls.Add(this.textBox1);
            this.groupBoxMain.Controls.Add(this.textBoxFile);
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(196, 326);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_save;
            this.buttonSave.Location = new System.Drawing.Point(100, 245);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 50);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearch.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.zoom;
            this.buttonSearch.Location = new System.Drawing.Point(6, 245);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 50);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSort.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_sort;
            this.buttonSort.Location = new System.Drawing.Point(106, 163);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(80, 47);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFilter.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_edit;
            this.ButtonFilter.Location = new System.Drawing.Point(6, 163);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(80, 50);
            this.ButtonFilter.TabIndex = 2;
            this.ButtonFilter.UseVisualStyleBackColor = true;
            this.ButtonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // textBoxSave
            // 
            this.textBoxSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSave.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSave.Location = new System.Drawing.Point(119, 232);
            this.textBoxSave.Multiline = true;
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.ReadOnly = true;
            this.textBoxSave.Size = new System.Drawing.Size(49, 18);
            this.textBoxSave.TabIndex = 0;
            this.textBoxSave.Text = "Сохранить";
            this.textBoxSave.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(29, 233);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(30, 17);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Найти";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBoxSort
            // 
            this.textBoxSort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSort.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSort.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSort.Location = new System.Drawing.Point(115, 151);
            this.textBoxSort.Multiline = true;
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.ReadOnly = true;
            this.textBoxSort.Size = new System.Drawing.Size(63, 12);
            this.textBoxSort.TabIndex = 0;
            this.textBoxSort.Text = "Сортировать";
            this.textBoxSort.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(51, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(94, 17);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Открыть файл";
            // 
            // textBoxFile
            // 
            this.textBoxFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFile.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFile.Location = new System.Drawing.Point(6, 151);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(94, 12);
            this.textBoxFile.TabIndex = 0;
            this.textBoxFile.Text = "Редактировать файл";
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
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenFile.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_add;
            this.buttonOpenFile.Location = new System.Drawing.Point(29, 35);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(129, 50);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
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
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
    }
}

