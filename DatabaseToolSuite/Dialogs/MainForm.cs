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
    public partial class MainForm : Form
    {

        Repositoryes.DatabaseRepository repository;

        public MainForm()
        {
            InitializeComponent();

            repository = new Repositoryes.DatabaseRepository();

            GetTables(repository.DataSet);
        }


        private void GetTables(DataSet dataSet)
        {
            databaseTreeView.Nodes.Clear();

            TreeNode databaseNode = databaseTreeView.Nodes.Add("Database", "База данных", 0, 0);

            foreach (DataTable table in dataSet.Tables)
            {
                TreeNode tableNode = databaseNode.Nodes.Add(table.TableName, table.TableName, 1, 2);
                tableNode.Tag = table;
            }
        }


        

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            this.Text = repository.DataSet.ExistsOkatoCode("00").ToString();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Открыть данные";
            dialog.Multiselect = false;
            dialog.Filter = "Документ XML(.xml)|*.xml|XML Schema File(.xsd)|*.xsd";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    repository.ReadXml(dialog.FileName);
                    //okatoComboBox1.SetData(repository.DataSet.okato);
                }
                else
                {
                    repository.ReadSchema(dialog.FileName);
                    GetTables(repository.DataSet);
                }
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Сохранить данные";
            dialog.Filter = "Документ XML(.xml)|*.xml|XML Schema File(.xsd)|*.xsd";
            if (dialog.ShowDialog(this)== DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    repository.WriteXml(dialog.FileName);
                }
                else
                {
                    repository.WriteSchema(dialog.FileName);
                }
            }            
        }

        private void mnuFileImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Импортировать данные";
            dialog.Multiselect = false;
            dialog.Filter = "Файл Microsoft Excel, содержащий значения, разделенные запятыми (.csv)|*.csv";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    int[] linkIndexes = new int[] { };
                    ImportProcessDialog importDialog = new ImportProcessDialog(repositoryDataSet.gasps, dialog.FileName, linkIndexes);
                    importDialog.ShowDialog(this);
                }
                else
                {
                    
                }
            }
        }

        private void mnuFileExport_Click(object sender, EventArgs e)
        {
            OkatoEditDialog dialog = new OkatoEditDialog(repository.DataSet.okato);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void databaseTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           if (e.Node.Tag is DataTable)
            {
                mainDataGridView.DataSource = (DataTable)e.Node.Tag;
                Services.DataGridViewSetting.SetSetting(mainDataGridView);
            }
        }

        
        private void mainDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataGridView control = (DataGridView)sender;
            if (control.DataSource is Repositoryes.RepositoryDataSet.okatoDataTable)
            {
                if (control.SelectedRows.Count > 0 && control.SelectedRows[0].Cells["ter"].Value is string)
                {
                    EditOkatoItem(control.SelectedRows[0]);
                }                
            }
        }

        private void mnuDatabaseAddOkato_Click(object sender, EventArgs e)
        {
            AddOkatoItem();
        }


        private void AddOkatoItem()
        {
            OkatoEditDialog dialog = new OkatoEditDialog(repository.DataSet.okato);
            dialog.Text = "Добавить строку ОКАТО";
            if (dialog.ShowDialog(this)== DialogResult.OK)
            {
                okatoRow row =(okatoRow) repository.DataSet.okato.NewRow();
                row.centrum = dialog.OkatoCentrum;
                row.code = dialog.Code;
                row.genitive = dialog.OkatoGenitive;
                row.kod1 =(Int16) dialog.Kod1;
                row.lab = dialog.Lab;
                row.name = dialog.OkatoName;
                row.name2 = dialog.OkatoName2;
                row.okato = dialog.Okato;
                row.ter = dialog.Ter.ToString();
                repository.DataSet.okato.Rows.Add(row);
            }
        }


        private void EditOkatoItem(DataGridViewRow row)
        {
            OkatoEditDialog dialog = new OkatoEditDialog(int.Parse(row.Cells["ter"].Value.ToString()),
                       int.Parse(row.Cells["kod1"].Value.ToString()),
                       row.Cells["lab"].Value.ToString(),
                       row.Cells["name"].Value.ToString(),
                       row.Cells["name2"].Value.ToString(),
                       row.Cells["centrum"].Value.ToString(),
                       row.Cells["genitive"].Value.ToString(),
                       repository.DataSet.okato);
            dialog.Text = "Править строку ОКАТО";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                row.Cells["ter"].Value = dialog.Ter;
                row.Cells["kod1"].Value = dialog.Kod1;
                row.Cells["lab"].Value = dialog.Lab;
                row.Cells["name"].Value = dialog.OkatoName;
                row.Cells["name2"].Value = dialog.OkatoName2;
                row.Cells["centrum"].Value = dialog.OkatoCentrum;
                row.Cells["genitive"].Value = dialog.OkatoGenitive;
            }
        }

        private void mainToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
