
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
            this.panelMainEdit = new System.Windows.Forms.Panel();
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.panelMainEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainEdit
            // 
            this.panelMainEdit.Controls.Add(this.dataGridViewEdit);
            this.panelMainEdit.Location = new System.Drawing.Point(12, 98);
            this.panelMainEdit.Name = "panelMainEdit";
            this.panelMainEdit.Size = new System.Drawing.Size(767, 319);
            this.panelMainEdit.TabIndex = 0;
            // 
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.Size = new System.Drawing.Size(761, 313);
            this.dataGridViewEdit.TabIndex = 0;
            this.dataGridViewEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainEdit);
            this.Name = "FormEditTable";
            this.Text = "Edit Table";
            this.Load += new System.EventHandler(this.FormEditTable_Load);
            this.panelMainEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainEdit;
        public System.Windows.Forms.DataGridView dataGridViewEdit;
    }
}