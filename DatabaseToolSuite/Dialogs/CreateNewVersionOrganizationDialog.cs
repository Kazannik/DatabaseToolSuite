using System;
using System.Windows.Forms;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Dialogs
{
    internal partial class CreateNewVersionOrganizationDialog : DatabaseToolSuite.Dialogs.ActionsDialog
    {
        private string oldName;
        private string oldOkato;
        private long oldAuthorityId;
        private long oldOwnerKey;
        private long oldCourtTypeId;

        public CreateNewVersionOrganizationDialog() : base()
        {
            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

            okatoComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.okato);
            authorityComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.authority);

            beginDateTimePicker.MinDate = Services.MasterDataSystem.MIN_DATE;
            beginDateTimePicker.MaxDate = Services.MasterDataSystem.MAX_DATE;

            OkButtonEnabled = false;
        }

        public CreateNewVersionOrganizationDialog(gaspsRow row): base(row)
        {
            oldName = DataRow.name;
            oldOkato = DataRow.okato_code;
            oldAuthorityId = DataRow.authority_id;
            oldOwnerKey = DataRow.owner_id;
            oldCourtTypeId = DataRow.court_type_id;

            InitializeComponent();

            okButton.Top = Height - 72;
            okButton.Left = Width - 184;
            cancelButton.Top = Height - 72;
            cancelButton.Left = Width - 103;

            codeTextBox.Text = DataRow.code;

            okatoComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.okato);
            authorityComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.authority);
            
            beginDateTimePicker.MinDate = Services.MasterDataSystem.MIN_DATE;
            beginDateTimePicker.MaxDate = Services.MasterDataSystem.MAX_DATE;

            Text = "Новая версия записи о подразделении";
            captionLabel.Text = "Укажите дату введения новой версии записи о подразделении правоохранительного органа";

            beginDateTimePicker.Value = DateTime.Today;
            nameTextBox.Text= DataRow.name;
            okatoComboBox.Code  = DataRow.okato_code;
            authorityComboBox.Code = DataRow.authority_id.ToString("00");
            OrganizationOwner = DataRow.owner_id;

            if (DataRow.owner_id > 0)
            {
                gaspsRow owner = Services.FileSystem.Repository.DataSet.gasps.GetLastVersionOrganizationFromKey(DataRow.owner_id);
                
                ownerTextBox.Text = owner.name + " (код: " + owner.code + ")";
            }
            else
                ownerTextBox.Text = string.Empty;

            OkButtonEnabled = false;
        }      

        public DateTime BeginDate
        {
            get { return beginDateTimePicker.Value; }
        }

        public string OrganizationName
        {
            get { return nameTextBox.Text; }
        }

        public string OkatoCode
        {
            get { return okatoComboBox.Code; }
        }

        public long? Authority
        {
            get { return authorityComboBox.Value; }
        }

        public long OrganizationOwner { get; private set; }

        public long CourtType { get { return oldCourtTypeId; } }

        private void selectOwnerButton_Click(object sender, EventArgs e)
        {
            SelectOrganizationDialog dialog;
            if (!string.IsNullOrWhiteSpace(okatoComboBox.Code) &&
                authorityComboBox.Value.HasValue){
                dialog = new SelectOrganizationDialog(authorityComboBox.Value.Value, okatoComboBox.Code);
            }
            else
            {
                dialog = new SelectOrganizationDialog();
            }
            
            dialog.UnlockShow = true;
            dialog.LockShow = false;
            dialog.ReserveShow = false;
            dialog.LastLockOnlyShow = false;

            if (dialog.ShowDialog(this)== DialogResult.OK)
            {
                OrganizationOwner = dialog.DataRow.key;
                ownerTextBox.Text = dialog.DataRow.name + " (код: " + dialog.DataRow.code +")";
            }
        }

        private void deleteOwnerButton_Click(object sender, EventArgs e)
        {
            OrganizationOwner = 0;
            ownerTextBox.Text = string.Empty;
        }

        private void Controls_ValueChanged(object sender, EventArgs e)
        {
            if (
                oldAuthorityId != Authority ||
                oldCourtTypeId != CourtType ||
                oldName != OrganizationName ||
                oldOkato != OkatoCode ||
                oldOwnerKey != OrganizationOwner 
                )
            {
                OkButtonEnabled = true;
            }
            else
            {
                OkButtonEnabled = false;
            }
            if (string.IsNullOrWhiteSpace(codeTextBox.Text) ||
                string.IsNullOrWhiteSpace(OrganizationName) ||
                !Authority.HasValue ||
                string.IsNullOrWhiteSpace(OkatoCode))
                OkButtonEnabled = false;

            deleteOwnerButton.Enabled = OrganizationOwner != 0;
        }
    }
}
