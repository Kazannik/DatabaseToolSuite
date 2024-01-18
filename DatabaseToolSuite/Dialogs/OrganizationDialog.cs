using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Dialogs
{
    public partial class OrganizationDialog : Form
    {

        public OrganizationDialog(gaspsRow row, okatoDataTable okato, authorityDataTable authority)
        {
            InitializeComponent();

            okatoComboBox.InitializeSource(okato);
            authorityComboBox.InitializeSource(authority);
            codeTextBox.Text = row.code;
            authorityComboBox.Code = row.authority_id.ToString("00");
            okatoComboBox.Code = row.okato_code;
            nameTextBox.Text = row.name;
            beginDateTextBox.Text = row.date_beg.ToLongDateString();
            endDateTextBox.Text = row.date_end.ToLongDateString(); 
            if (row.date_end <= DateTime.Today)
            {
                endDateTextBox.ForeColor = Color.Red;
            }
        }

        public OrganizationDialog()
        {
            InitializeComponent();
        }

        private void OrganizationDialog_Load(object sender, EventArgs e)
        {

        }

        private void lockCodeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
