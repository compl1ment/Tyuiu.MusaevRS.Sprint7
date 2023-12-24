
namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbout.Location = new System.Drawing.Point(284, 103);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(462, 167);
            this.textBoxAbout.TabIndex = 0;
            this.textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Image = global::Tyuiu.MusaevRS.Sprint7.Project.V9.Properties.Resources.resize_image_online_com_1701928794_mishkajpg_Fjwr0g43;
            this.pictureBoxAbout.Location = new System.Drawing.Point(26, 86);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(252, 242);
            this.pictureBoxAbout.TabIndex = 1;
            this.pictureBoxAbout.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.textBoxAbout);
            this.Name = "FormAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
    }
}