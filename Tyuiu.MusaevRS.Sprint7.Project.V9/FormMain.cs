using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;

namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{

    public partial class FormMain : MaterialForm
    {
        public static string fileName;
        
        public static string[,] LoadFromFileData(string fileName)
        {
            string fileData = File.ReadAllText(fileName);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }
        public FormMain()
        {
            InitializeComponent();
            

        }
        private void LoadDataIntoDataGridView(string fileName)
        {

            string[,] dataArray = LoadFromFileData(fileName);


            dataGridViewMain.Rows.Clear();
            dataGridViewMain.Columns.Clear();


            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewMain.Columns.Add("", dataArray[0, i]);
            }


            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewMain.Rows.Add(rowData.ToArray());
            }
        }                                

        
        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTask = new OpenFileDialog();
            openFileDialogTask.Filter = "csv Files|*.csv";
            DialogResult res = openFileDialogTask.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fileName = openFileDialogTask.FileName;
                LoadDataIntoDataGridView(fileName);
            }

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogOpen.FileName = "OutPutFile.csv";
            saveFileDialogOpen.ShowDialog();
            string filePathSavedFile = saveFileDialogOpen.FileName;
            FileInfo fileInfo = new FileInfo(filePathSavedFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(filePathSavedFile);
            }
        }

        private void dataGridViewMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            FormEditTable formEditTable = new FormEditTable();
            formEditTable.Show();
        }
    }






}
