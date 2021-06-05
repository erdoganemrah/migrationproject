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
    public partial class AddDepartment_Postgres : Form
    {
        public AddDepartment_Postgres()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            PostgreSQLDb db = new PostgreSQLDb();
            int departmentId = db.AddDepartment(txtName.Text, txtGroupName.Text);
            txtDepartmentID.Text = departmentId.ToString();
            txtModDate.Text = DateTime.Now.ToString();
        }
    }
}
