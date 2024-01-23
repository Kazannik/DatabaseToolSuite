using System;
using System.Windows.Forms;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Dialogs
{
    internal partial class CreateNewOrganizationDialog : DatabaseToolSuite.Dialogs.CreateNewVersionOrganizationDialog
    {
        private bool generationCodeService = true;

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


        public CreateNewOrganizationDialog(string name, string code, DateTime beginDate) : base()
        {
            generationCodeService = false;

            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

            nextCodeButton.Enabled = false;
            selectCodeButton.Enabled = false;

            nameTextBox.Text = name;
            nameTextBox.Enabled = false;
            codeTextBox.Text = code;
            codeTextBox.Enabled = false;
            beginDateTimePicker.Value = beginDate;
            beginDateTimePicker.Enabled = false;

            Text = "Новая записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой записи о подразделении правоохранительного органа";
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
                if (generationCodeService)
                {
                    codeTextBox.Text = Services.FileSystem.Repository.DataSet.gasps.GetNextCode(authority: Authority.HasValue ? Authority.Value : 0, okato: OkatoCode);
                    nextCodeButton.Enabled = true;
                    selectCodeButton.Enabled = true;
                }
            }
        }
    }
}
