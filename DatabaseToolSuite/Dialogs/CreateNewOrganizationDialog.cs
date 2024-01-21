using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Dialogs
{
    internal partial class CreateNewOrganizationDialog : DatabaseToolSuite.Dialogs.CreateNewVersionOrganizationDialog
    {

        public CreateNewOrganizationDialog() : base()
        {
            InitializeComponent();

            selectCodeButton.Enabled = false;

            Text = "Новая записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой записи о подразделении правоохранительного органа";
        }

        public CreateNewOrganizationDialog(gaspsRow row) : base(row)
        {
            InitializeComponent();
            selectCodeButton.Enabled = false;
            Text = "Новая записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой записи о подразделении правоохранительного органа";
        }

        public string Code
        {
            get { return codeTextBox.Text; }
        }

        private void nextCodeButton_Click(object sender, EventArgs e)
        {
            codeTextBox.Text = Services.FileSystem.Repository.DataSet.gasps.GetNextCode(authority: Authority.HasValue ? Authority.Value: 0, okato: OkatoCode);
        }

        private void selectCodeButton_Click(object sender, EventArgs e)
        {
            SelectOrganizationDialog dialog = new SelectOrganizationDialog(authority: Authority.HasValue? Authority.Value: 0, okato: OkatoCode);
            dialog.LastLockOnlyShow = true;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                codeTextBox.Text = dialog.DataRow.code;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorityComboBox.Code)||
                string.IsNullOrWhiteSpace(okatoComboBox.Code))
            {
                selectCodeButton.Enabled = false;
            }
            else
            {
                selectCodeButton.Enabled = true;
            }
        }
    }
}
