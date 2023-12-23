using MaterialSkin.Controls;
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
    public partial class FormEditTable : MaterialForm
    {
        public FormEditTable()
        {
            InitializeComponent();
        }

        private void FormEditTable_Load(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            dataGridViewEdit = formMain.dataGridViewMain;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
