
namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    partial class FormEditTable
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
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.dataGridViewEdit);
            this.groupBoxMain.Location = new System.Drawing.Point(12, -2);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(776, 410);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.ColumnHeadersVisible = false;
            this.dataGridViewEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEdit.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.RowHeadersVisible = false;
            this.dataGridViewEdit.Size = new System.Drawing.Size(770, 391);
            this.dataGridViewEdit.TabIndex = 0;
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonSaveFile);
            this.groupBoxButton.Location = new System.Drawing.Point(12, 411);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(773, 35);
            this.groupBoxButton.TabIndex = 1;
            this.groupBoxButton.TabStop = false;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile.Location = new System.Drawing.Point(0, 6);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(773, 29);
            this.buttonSaveFile.TabIndex = 0;
            this.buttonSaveFile.Text = "Сохранить изменения";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // FormEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormEditTable";
            this.Text = "FormEditTable";
            this.Load += new System.EventHandler(this.FormEditTable_Load);
            this.groupBoxMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.groupBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxMain;
        public System.Windows.Forms.DataGridView dataGridViewEdit;
        public System.Windows.Forms.GroupBox groupBoxButton;
        public System.Windows.Forms.Button buttonSaveFile;
    }
}