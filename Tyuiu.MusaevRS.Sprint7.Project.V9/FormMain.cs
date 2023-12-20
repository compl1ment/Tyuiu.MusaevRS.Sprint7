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
                    

                    fileName = openFileDialogTask.FileName;

                    

                    // Путь к файлу CSV
                    string csvFilePath = fileName;

                    // Создаем DataTable для хранения данных из CSV
                    DataTable dataTable = new DataTable();

                    // Читаем содержимое файла CSV
                    using (StreamReader reader = new StreamReader(csvFilePath))
                    {
                        // Читаем первую строку, чтобы получить заголовки столбцов
                        string headerLine = reader.ReadLine();
                        string[] headers = headerLine.Split(',');

                        // Создаем столбцы DataTable на основе заголовков
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        // Читаем остальные строки и добавляем их в DataTable
                        while (!reader.EndOfStream)
                        {
                            string dataLine = reader.ReadLine();
                            string[] data = dataLine.Split(',');

                            // Добавляем строку данных в DataTable
                            dataTable.Rows.Add(data);
                        }
                    }

                    

                    
                    
                    dataGridViewMain.Dock = DockStyle.Fill;
                    dataGridViewMain.DataSource = dataTable;

                    
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
        

        private void toolStripComboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[Convert.ToString(toolStripComboBoxMain.SelectedItem)];

            dataGridViewMain.DataSource = table;

        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
