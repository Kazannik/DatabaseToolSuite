using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseToolSuite.Dialogs
{
    public partial class AppForm : Form
    {

        public AppForm()
        {
            InitializeComponent();            

            selectedRowStatusLabel.Text = string.Empty;
            mnuTableCreateOrganization.Enabled = false;
            mnuTableCreateNewVersion.Enabled = false;
            mnuTableRemoveOrganization.Enabled = false;

            if (Services.FileSystem.DefaultDatabaseFileExists())
                Services.FileSystem.ReadDatabase();

            gaspsListView.DataSet = Services.FileSystem.Repository.DataSet;

            filterOkatoComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.okato);
            filterAuthorityComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.authority);
            rowCountStatusLabel.Text = string.Format("Отражено записей {0}", gaspsListView.RowCount);
        }

        private void Filter_ParametersChanged(object sender, EventArgs e)
        {
            gaspsListView.SetFilter(authority: filterAuthorityComboBox.Value,
                okato: filterOkatoComboBox.Code,
                code: filterCodeNumericTextBox.Text,
                name: filterNameTextBox.Text,
                unlockShow: true,
                reserveShow: true,
                lockShow: filterLockCodeViewCheckBox.Checked);

            rowCountStatusLabel.Text = string.Format("Отражено записей {0}", gaspsListView.RowCount);
        }

        private void gaspsListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            if (gaspsListView.DataRow != null)
            {
                selectedRowStatusLabel.Text = gaspsListView.DataRow.code.ToString();
                mnuTableCreateOrganization.Enabled = true;
                mnuTableCreateNewVersion.Enabled = Services.FileSystem.Repository.DataSet.gasps.IsLastVersion(gaspsListView.DataRow.version);                
                mnuTableRemoveOrganization.Enabled = gaspsListView.DataRow.date_end > DateTime.Today;
            }
            else
            {
                selectedRowStatusLabel.Text = string.Empty;
                mnuTableCreateOrganization.Enabled = false;
                mnuTableCreateNewVersion.Enabled = false;
                mnuTableRemoveOrganization.Enabled = false;
            }
        }

        private void TableNewOrganization_Click(object sender, EventArgs e)
        {
            CreateNewOrganizationDialog dialog = new CreateNewOrganizationDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Services.MasterDataSystem.CreateNewOrganization(
                    name: dialog.OrganizationName,
                    okato: dialog.OkatoCode,
                    authorityId: dialog.Authority.HasValue ? dialog.Authority.Value : 0,
                    code: dialog.Code,
                    ownerKey: dialog.OrganizationOwner,
                    dateBegin: dialog.BeginDate,
                    dateEnd: Services.MasterDataSystem.MAX_DATE,
                    courtTypeId: dialog.CourtType);
                gaspsListView.UpdateListViewItem();
            }
        }

        private void TableCreateOrganization_Click(object sender, EventArgs e)
        {
            CreateNewOrganizationDialog dialog = new CreateNewOrganizationDialog(gaspsListView.DataRow);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Services.MasterDataSystem.CreateNewOrganization(
                    name: dialog.OrganizationName,
                    okato: dialog.OkatoCode,
                    authorityId: dialog.Authority.HasValue ? dialog.Authority.Value : 0,
                    code: dialog.Code,
                    ownerKey: dialog.OrganizationOwner,
                    dateBegin: dialog.BeginDate,
                    dateEnd: Services.MasterDataSystem.MAX_DATE,
                    courtTypeId: dialog.CourtType);
                gaspsListView.UpdateListViewItem();
            }
        }

        private void TableCreateVersion_Click(object sender, EventArgs e)
        {
            CreateNewVersionOrganizationDialog dialog = new CreateNewVersionOrganizationDialog(gaspsListView.DataRow);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                long version = gaspsListView.DataRow.version;
                Services.MasterDataSystem.CreateNewVersionOrganization(
                    version: version, 
                    date: dialog.BeginDate,
                    name: dialog.OrganizationName,
                    okato: dialog.OkatoCode,
                    authorityId: dialog.Authority.HasValue ? dialog.Authority.Value: 0,
                    ownerKey: dialog.OrganizationOwner,
                    courtTypeId: dialog.CourtType);
                gaspsListView.UpdateListViewItem();
            }
        }

        private void TableRemoveOrganization_Click(object sender, EventArgs e)
        {
            RemoveOrganizationDialog dialog = new RemoveOrganizationDialog(gaspsListView.DataRow);
            if (dialog.ShowDialog(this)== DialogResult.OK)
            {
                long version = gaspsListView.DataRow.version;
                Services.MasterDataSystem.RemoveOrganization(version: version, date: dialog.LockDate);
                gaspsListView.UpdateListViewItem();
            }
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Services.FileSystem.Repository.DataSet.HasChanges())
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Services.FileSystem.WriteDatabase();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }                
            }
            else
            {
                if (Services.FileSystem.Repository.DataSet.HasChanges())
                {
                    Services.FileSystem.RescueDatabase();
                }
            }
        }

        private void HelpStatistic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всего добавлено/изменено/заблокировано в 2023 году записей: " + 
                Services.FileSystem.Repository.DataSet.gasps.GetEditedRowCount().ToString(), "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Открыть данные";
            dialog.Multiselect = false;
            dialog.Filter = "Документ XML(.xml)|*.xml|XML Schema File(.xsd)|*.xsd";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    Services.FileSystem.ReadDatabase(dialog.FileName);
                }
                else
                {
                    Services.FileSystem.ReadSchema(dialog.FileName);
                }

                gaspsListView.DataSet = Services.FileSystem.Repository.DataSet;

                filterOkatoComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.okato);
                filterAuthorityComboBox.InitializeSource(Services.FileSystem.Repository.DataSet.authority);
                rowCountStatusLabel.Text = string.Format("Отражено записей {0}", gaspsListView.RowCount);
            }
        }

        private void FileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Services.FileSystem.DatabaseFileName))
            {
                FileSaveAs();
            }
            else
            {
                Services.FileSystem.WriteDatabase();
            }
        }

        private void FileSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSaveAs();
        }

        private void FileSaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Сохранить данные";
            dialog.Filter = "Документ XML(.xml)|*.xml|XML Schema File(.xsd)|*.xsd";
            dialog.FileName = string.IsNullOrWhiteSpace(Services.FileSystem.DatabaseFileName) ? "gasps.xml": Services.FileSystem.DatabaseFileName;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    Services.FileSystem.WriteDatabase(dialog.FileName);
                }
                else
                {
                    Services.FileSystem.WriteSchema(dialog.FileName);
                }
            }
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отдел ведения единой нормативно-справочной информации", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
