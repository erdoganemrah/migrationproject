using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakarya1
{
    public partial class winFrmPostgreSQL : Form
    {
        public winFrmPostgreSQL()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetDepartments();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment_Postgres frm = new AddDepartment_Postgres();
            frm.ShowDialog();
            GetDepartments();            
        }

        private void winFrmPostgreSQL_Load(object sender, EventArgs e)
        {
            GetDepartments();
        }

        private void btnDelDepartment_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridView.Rows[selectedrowindex];
                int departmentId = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    PostgreSQLDb db = new PostgreSQLDb();
                    db.DelDepartment(departmentId);
                    GetDepartments();
                }
            }
        }

        public void GetDepartments()
        {
            PostgreSQLDb db = new PostgreSQLDb();
            gridView.DataSource = db.GetDepartments();
        }

        private void btnUpdDepartment_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridView.Rows[selectedrowindex];
                int departmentId = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);

                UpdDepartment_Postgres frm = new UpdDepartment_Postgres();
                frm.txtDepartmentID.Text = departmentId.ToString();
                frm.ShowDialog();

                GetDepartments();
            }
        }
    }
}
