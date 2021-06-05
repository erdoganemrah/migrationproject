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
    public partial class UpdDepartment : Form
    {
        AdventureWorks2019Entities db;
        public UpdDepartment()
        {
            InitializeComponent();
        }

        private void UpdDepartment_Load(object sender, EventArgs e)
        {
            db = new AdventureWorks2019Entities();
            int departmentId = Convert.ToInt32(txtDepartmentID.Text);
            var guncellenecekDepartment = db.Departments.Where(d => d.DepartmentID == departmentId).First();

            txtName.Text = guncellenecekDepartment.Name;
            txtGroupName.Text = guncellenecekDepartment.GroupName;
            txtModDate.Text = guncellenecekDepartment.ModifiedDate.ToString();
        }

        private void btnUpdDepartment_Click(object sender, EventArgs e)
        {
            db = new AdventureWorks2019Entities();
            int departmentId = Convert.ToInt32(txtDepartmentID.Text);
            var guncellenecekDepartment = db.Departments.Where(d => d.DepartmentID == departmentId).FirstOrDefault();
            guncellenecekDepartment.Name = txtName.Text;
            guncellenecekDepartment.GroupName = txtGroupName.Text;
            guncellenecekDepartment.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            this.Close();
        }
    }
}
