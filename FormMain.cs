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
    public partial class FormMain : Form
    {
        public static List<string> names = new List<string>();

        public FormMain()
        {
            InitializeComponent();
            names.Add("Jake");
            names.Add("Adam");
            names.Add("John");
            lstnames.DataSource = names;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddName frmAddName = new FormAddName();
            frmAddName.ShowDialog();
            names.Sort();
            lstnames.DataSource = null;
            lstnames.DataSource = names;
        }

        private void btnRemoveNames_Click(object sender, EventArgs e)
        {
            names.RemoveAt(lstnames.SelectedIndex);
            names.Sort();
            lstnames.DataSource = null;
            lstnames.DataSource = names;
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            FormChangeName frmChangeName = new FormChangeName();
            frmChangeName.ShowDialog();
            names.Sort();
            lstnames.DataSource = null;
            lstnames.DataSource = names;
        }
    }
}
