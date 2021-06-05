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
    public partial class winFrmMSSQL : Form
    {
        AdventureWorks2019Entities db;
        public winFrmMSSQL()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetDepartments();
        }
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            PG_AddDepartment frm = new PG_AddDepartment();
            frm.ShowDialog();
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
                    var silinecekDepartment = db.Departments.Where(d => d.DepartmentID == departmentId).FirstOrDefault();
                    db.Departments.Remove(silinecekDepartment);
                    db.SaveChanges();
                    GetDepartments();
                }
            }
        }

        void GetDepartments()
        {
            db = new AdventureWorks2019Entities();
            gridView.DataSource = db.Departments.Select(d => new { d.DepartmentID, d.Name, d.GroupName, d.ModifiedDate }).OrderByDescending(d => d.ModifiedDate).ToList();
        }

        private void btnUpdDepartment_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridView.Rows[selectedrowindex];
                int departmentId = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);

                UpdDepartment frm = new UpdDepartment();
                frm.txtDepartmentID.Text = departmentId.ToString();
                frm.ShowDialog();

                GetDepartments();
            }
        }

        private void winFrmMSSQL_Load(object sender, EventArgs e)
        {
            GetDepartments();
        }
    }
}
