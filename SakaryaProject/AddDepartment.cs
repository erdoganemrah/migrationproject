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
    public partial class PG_AddDepartment : Form
    {
        public PG_AddDepartment()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {            
            AdventureWorks2019Entities db = new AdventureWorks2019Entities();
            Department department = new Department()
            {
                Name = txtName.Text,
                GroupName = txtGroupName.Text,
                ModifiedDate = DateTime.Now
            };
            db.Departments.Add(department);
            db.SaveChanges();
            txtDepartmentID.Text = department.DepartmentID.ToString();
            txtModDate.Text = DateTime.Now.ToString();
        }
    }
}
