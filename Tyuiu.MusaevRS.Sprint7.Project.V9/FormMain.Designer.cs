
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxEditFile = new System.Windows.Forms.TextBox();
            this.buttonEditFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.toolTipOpenFile = new System.Windows.Forms.ToolTip(this.components);
            this.panelNoMain = new System.Windows.Forms.Panel();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSaveFile = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogOpen = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelNoMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.textBoxEditFile);
            this.panelMain.Controls.Add(this.buttonEditFile);
            this.panelMain.Controls.Add(this.buttonOpenFile);
            this.panelMain.Location = new System.Drawing.Point(12, 69);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(806, 101);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxEditFile
            // 
            this.textBoxEditFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxEditFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditFile.Location = new System.Drawing.Point(634, 76);
            this.textBoxEditFile.Multiline = true;
            this.textBoxEditFile.Name = "textBoxEditFile";
            this.textBoxEditFile.ReadOnly = true;
            this.textBoxEditFile.Size = new System.Drawing.Size(165, 18);
            this.textBoxEditFile.TabIndex = 2;
            // 
            // buttonEditFile
            // 
            this.buttonEditFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEditFile.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.application_form_edit;
            this.buttonEditFile.Location = new System.Drawing.Point(659, 15);
            this.buttonEditFile.Name = "buttonEditFile";
            this.buttonEditFile.Size = new System.Drawing.Size(106, 60);
            this.buttonEditFile.TabIndex = 1;
            this.toolTipEdit.SetToolTip(this.buttonEditFile, "Редактировать файл");
            this.buttonEditFile.UseVisualStyleBackColor = false;
            this.buttonEditFile.Click += new System.EventHandler(this.buttonEditFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenFile.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.application_form_add;
            this.buttonOpenFile.Location = new System.Drawing.Point(31, 15);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(106, 60);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTipOpenFile.SetToolTip(this.buttonOpenFile, "Открыть файл расширения .csv");
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDataGridView.Controls.Add(this.dataGridViewMain);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 176);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(806, 280);
            this.panelDataGridView.TabIndex = 0;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(800, 274);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick_1);
            // 
            // panelNoMain
            // 
            this.panelNoMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelNoMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNoMain.Controls.Add(this.buttonSaveFile);
            this.panelNoMain.Controls.Add(this.buttonHelp);
            this.panelNoMain.Location = new System.Drawing.Point(827, 69);
            this.panelNoMain.Name = "panelNoMain";
            this.panelNoMain.Size = new System.Drawing.Size(145, 387);
            this.panelNoMain.TabIndex = 1;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveFile.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.application_put;
            this.buttonSaveFile.Location = new System.Drawing.Point(18, 105);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(106, 60);
            this.buttonSaveFile.TabIndex = 0;
            this.toolTipSaveFile.SetToolTip(this.buttonSaveFile, "Сохранить файл");
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(18, 15);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(106, 60);
            this.buttonHelp.TabIndex = 0;
            this.toolTipHelp.SetToolTip(this.buttonHelp, "Подробная информация");
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(177, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.panelNoMain);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "Tyuiu.MusaevRS.Sprint7.Project.V9";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelNoMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panelDataGridView;
        public System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ToolTip toolTipOpenFile;
        private System.Windows.Forms.Panel panelNoMain;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTipSaveFile;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.Button buttonEditFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOpen;
        private System.Windows.Forms.TextBox textBoxEditFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}

