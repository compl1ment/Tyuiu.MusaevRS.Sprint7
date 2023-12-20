using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;


namespace Tyuiu.MusaevRS.Sprint7.Project.V9
{
    public partial class FormEditTable : Form
    {
        public FormEditTable()
        {
            InitializeComponent();
        }

        private void FormEditTable_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Предположим, у нас есть двумерный массив строк, который мы хотим сохранить
                string[,] data = {
                    { "Header1", "Header2", "Header3" },
                    { "Row1Col1", "Row1Col2", "Row1Col3" },
                       { "Row2Col1", "Row2Col2", "Row2Col3" },};
                // ... Добавьте столько строк, сколько нужно


                // Путь к файлу CSV, который вы хотите создать или перезаписать
                string csvFilePath = @"C:\path\to\your\file.csv";

                // Создание StringBuilder для накопления строк CSV
                StringBuilder csvContent = new StringBuilder();

                // Получение размеров массива
                int rowCount = data.GetLength(0);
                int colCount = data.GetLength(1);

                // Перебираем строки
                for (int row = 0; row < rowCount; row++)
                {
                    // Для каждой строки перебираем столбцы
                    for (int col = 0; col < colCount; col++)
                    {
                        // Добавляем значение в строку CSV, заменяем внутренние кавычки и экранируем значения
                        string value = data[row, col];
                        value = value.Replace("\"", "\"\""); // Замена " на ""
                        if (value.Contains(",") || value.Contains("\""))
                            value = $"\"{value}\""; // Обрамляем значения кавычками, если они содержат запятые или кавычки

                        csvContent.Append(value);

                        // Если колонка не последняя, добавляем разделитель
                        if (col < colCount - 1)
                        {
                            csvContent.Append(",");
                        }
                    }

                    // После обработки всех колонок строки добавляем новую строку
                    if (row < rowCount - 1)
                    {
                        csvContent.AppendLine();
                    }
                }

                // Записываем строку CSV в файл
                File.WriteAllText(csvFilePath, csvContent.ToString());           

            }
            catch
            {
                MessageBox.Show("Ошибка","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
       
    }
}
