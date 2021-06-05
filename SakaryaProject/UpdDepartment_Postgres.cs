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
    public partial class UpdDepartment_Postgres : Form
    {
        public UpdDepartment_Postgres()
        {
            InitializeComponent();
        }

        private void btnUpdDepartment_Click(object sender, EventArgs e)
        {
            int departmentId = Convert.ToInt32(txtDepartmentID.Text);
            PostgreSQLDb db = new PostgreSQLDb();        
            db.UpdDepartment(departmentId, txtName.Text, txtGroupName.Text);            
            txtModDate.Text = DateTime.Now.ToString();
        }

        private void UpdDepartment_Postgres_Load(object sender, EventArgs e)
        {
            PostgreSQLDb db = new PostgreSQLDb();
            int departmentId = Convert.ToInt32(txtDepartmentID.Text);
            PG_Department department = db.GetDepartment(departmentId);
            txtName.Text = department.Name;
            txtGroupName.Text = department.GroupName;
            txtModDate.Text = department.ModifiedDate.ToString();
        }
    }
}
