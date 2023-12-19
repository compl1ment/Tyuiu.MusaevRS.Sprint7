using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;


namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    
    public partial class FormMain : Form
    {
        public static string openFilePath;
        private string fileName = string.Empty;

        private DataTableCollection tableCollection = null;
        public FormMain()
        {
            InitializeComponent();
            ButtonFilter.Enabled = false;
            buttonSave.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSort.Enabled = false;
            toolStripMain.Visible = false;
            groupBoxDataGrid.Location = new Point(231, 10);
            groupBoxMain.Location = new Point(12, 10);

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
            FormEditTable formEditTable = new FormEditTable();
            formEditTable.Show();
            DataTable table = tableCollection[Convert.ToString(toolStripComboBoxMain.SelectedItem)];
            formEditTable.dataGridViewEdit.DataSource = table;
            
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {

                
                DialogResult res = openFileDialogTask.ShowDialog();
                if (res == DialogResult.OK)
                {
                    groupBoxDataGrid.Location = new Point(231, 31);
                    groupBoxMain.Location = new Point(12, 31);

                    ButtonFilter.Enabled = true;
                    buttonSave.Enabled = true;
                    buttonSearch.Enabled = true;
                    buttonSort.Enabled = true;

                    fileName = openFileDialogTask.FileName;

                    Text = fileName;

                    OpenExcelFile(fileName);

                    toolStripMain.Visible = true;
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void  OpenExcelFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            tableCollection = db.Tables;

            toolStripComboBoxMain.Items.Clear();

            foreach (DataTable table in tableCollection)
            {
                toolStripComboBoxMain.Items.Add(table.TableName);
            }
            toolStripComboBoxMain.SelectedIndex = 0;

        }

        private void toolStripComboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[Convert.ToString(toolStripComboBoxMain.SelectedItem)];

            dataGridViewMain.DataSource = table;

        }
    }
}
