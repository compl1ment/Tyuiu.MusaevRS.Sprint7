
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
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.button2);
            this.groupBoxMain.Controls.Add(this.button1);
            this.groupBoxMain.Controls.Add(this.buttonSort);
            this.groupBoxMain.Controls.Add(this.ButtonFilter);
            this.groupBoxMain.Controls.Add(this.textBox1);
            this.groupBoxMain.Controls.Add(this.textBoxSearch);
            this.groupBoxMain.Controls.Add(this.textBoxSort);
            this.groupBoxMain.Controls.Add(this.textBoxFile);
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(207, 325);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // textBoxFile
            // 
            this.textBoxFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile.Location = new System.Drawing.Point(43, 21);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(116, 17);
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
            // textBoxSort
            // 
            this.textBoxSort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSort.Location = new System.Drawing.Point(61, 91);
            this.textBoxSort.Multiline = true;
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.ReadOnly = true;
            this.textBoxSort.Size = new System.Drawing.Size(79, 17);
            this.textBoxSort.TabIndex = 0;
            this.textBoxSort.Text = "Сортировать";
            this.textBoxSort.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Location = new System.Drawing.Point(79, 171);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(42, 17);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Найти";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(69, 242);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Сохранить";
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_save;
            this.button2.Location = new System.Drawing.Point(43, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.zoom;
            this.button1.Location = new System.Drawing.Point(43, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSort.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_sort;
            this.buttonSort.Location = new System.Drawing.Point(43, 105);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(116, 41);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFilter.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.table_edit;
            this.ButtonFilter.Location = new System.Drawing.Point(43, 35);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(116, 41);
            this.ButtonFilter.TabIndex = 2;
            this.ButtonFilter.UseVisualStyleBackColor = true;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox1;
    }
}

