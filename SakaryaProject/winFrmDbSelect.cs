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
    public partial class winFrmDbSelect : Form
    {
        public winFrmDbSelect()
        {
            InitializeComponent();
        }

        private void btnMSSQL_Click(object sender, EventArgs e)
        {
            winFrmMSSQL frm = new winFrmMSSQL();
            frm.ShowDialog();
        }

        private void btnPostgreSQL_Click(object sender, EventArgs e)
        {
            winFrmPostgreSQL frm = new winFrmPostgreSQL();
            frm.ShowDialog();
        }
    }
}
