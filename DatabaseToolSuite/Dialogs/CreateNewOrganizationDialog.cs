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

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

            nextCodeButton.Enabled = !string.IsNullOrWhiteSpace(authorityComboBox.Code) ||
                !string.IsNullOrWhiteSpace(okatoComboBox.Code);

            selectCodeButton.Enabled = !string.IsNullOrWhiteSpace(authorityComboBox.Code) ||
                !string.IsNullOrWhiteSpace(okatoComboBox.Code);

            Text = "Новая записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой записи о подразделении правоохранительного органа";
            codeTextBox.Text = string.Empty;
        }

        public CreateNewOrganizationDialog(gaspsRow row) : base(row)
        {
            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

            nextCodeButton.Enabled = !string.IsNullOrWhiteSpace(authorityComboBox.Code) ||
                !string.IsNullOrWhiteSpace(okatoComboBox.Code);

            selectCodeButton.Enabled = !string.IsNullOrWhiteSpace(authorityComboBox.Code) ||
                !string.IsNullOrWhiteSpace(okatoComboBox.Code);

            Text = "Новая записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой записи о подразделении правоохранительного органа";
            codeTextBox.Text = string.Empty;
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
                nextCodeButton.Enabled = false;
                selectCodeButton.Enabled = false;
            }
            else
            {
                codeTextBox.Text = Services.FileSystem.Repository.DataSet.gasps.GetNextCode(authority: Authority.HasValue ? Authority.Value : 0, okato: OkatoCode);
                nextCodeButton.Enabled = true;
                selectCodeButton.Enabled = true;
            }
        }
    }
}
