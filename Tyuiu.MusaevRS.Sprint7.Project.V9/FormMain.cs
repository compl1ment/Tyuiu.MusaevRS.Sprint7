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
        public string fileName;
        public string fileNameEditTable;


        public string[,] LoadFromFileData(string fileName)
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
            dataGridViewMain.ReadOnly = true;
            buttonEditFile.Enabled = false;
            textBoxEditFile.Visible = false;
            textBoxEditFile.Text = "Редактирование отключено";


        }

        public void LoadDataIntoDataGridView(string fileName)
        {
            FormEditTable formEditTable = new FormEditTable();
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

        public void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTask = new OpenFileDialog();
            openFileDialogTask.Filter = "csv Files|*.csv";
            DialogResult res = openFileDialogTask.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fileName = openFileDialogTask.FileName;
                LoadDataIntoDataGridView(fileName);
                buttonEditFile.Enabled = true;
                textBoxEditFile.Visible = true;
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
            int rows = dataGridViewMain.RowCount;
            int columns = dataGridViewMain.ColumnCount;

            string str = "Название;Номер;Адрес;Телефон магазина;Фио поставщика;Телефон поставщика;Стоимость поставки\n";
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(filePathSavedFile, str + Environment.NewLine, Encoding.Default);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + filePathSavedFile + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = filePathSavedFile;
                txt.Start();
            }
        }

        private void dataGridViewMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            dataGridViewMain.ReadOnly = false;
            textBoxEditFile.Text = "Редактирование включено";


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout frmb = new FormAbout();
            frmb.Show();
        }
    }






}
