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
    internal partial class ActionsDialog : Form
    {
        public gaspsRow DataRow { get; }

        public ActionsDialog()
        {
            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

        }

        public ActionsDialog(gaspsRow row)
        {
            DataRow = row;

            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;
        }

        protected bool OkButtonEnabled
        {
            get { return okButton.Enabled; }
            set { okButton.Enabled = value; }
        }

        private void ActionsDialog_Resize(object sender, EventArgs e)
        {
            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;
        }
    }
}
