using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    
    public partial class FormMain : Form
    {
        public static string openFilePath;

        public FormMain()
        {
            InitializeComponent();
            ButtonFilter.Enabled = false;
            buttonSave.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSort.Enabled = false;
            

        }

        private void FormMain_Load(object sender, EventArgs e)
        {                                 

        }

        private void textBoxSort_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.ShowDialog();
                openFilePath = openFileDialogTask.FileName;
                ButtonFilter.Enabled = true;
                buttonSave.Enabled = true;
                buttonSearch.Enabled = true;
                buttonSort.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
