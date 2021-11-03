using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10_Multiple_Forms
{
    public partial class FormChangeName : Form
    {
        public FormChangeName()
        {
            InitializeComponent();
            lstNames.DataSource = FormMain.names;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (txtChangeNames.Text.Trim() != "")
            {
                FormMain.names.Add(txtAddNames.Text);
                FormMain.names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = FormMain.names;
                txtAddNames.Text = "";
            }
        }
    }
}
