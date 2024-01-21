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
    internal partial class RemoveOrganizationDialog : DatabaseToolSuite.Dialogs.ActionsDialog
    {

        public RemoveOrganizationDialog(gaspsRow row): base(row)
        {
            InitializeComponent();

            lockDateTimePicker.MinDate = Services.MasterDataSystem.MIN_DATE;
            lockDateTimePicker.MaxDate = Services.MasterDataSystem.MAX_DATE;

            Text = "Блокировка записи о подразделении";
            captionLabel.Text = "Укажите дату блокировки записи о подразделении правоохранительного органа";

            DetailsUpdate();
        }

        private void DetailsUpdate()
        {

            listView1.Items.Clear();
            listView1.Items.Add("Наименование").SubItems.Add(DataRow.name);
            listView1.Items.Add("Код подразделения").SubItems.Add(DataRow.code);
            listView1.Items.Add("Вид органа").SubItems.Add(DataRow.authority_id.ToString("00") + " - " + Services.FileSystem.Repository.DataSet.authority.GetName(DataRow.authority_id));
            listView1.Items.Add("ОКАТО").SubItems.Add(DataRow.okato_code + " - " + Services.FileSystem.Repository.DataSet.okato.GetName(DataRow.okato_code));
            listView1.Items.Add("Дата начала действия").SubItems.Add(DataRow.date_beg.ToShortDateString());
            listView1.Items.Add("Дата окончания действия").SubItems.Add(DataRow.date_end.ToShortDateString());
            if (DataRow.owner_id > 0)
            {
                gaspsRow owner = Services.FileSystem.Repository.DataSet.gasps.GetLastVersionOrganizationFromKey(DataRow.owner_id);
                listView1.Items.Add("Владелец").SubItems.Add("(" + owner.code + ") " + owner.name);
            }
        }
        
        public DateTime LockDate
        {
            get
            {
                return lockDateTimePicker.Value;
            }
        }
    }
}
