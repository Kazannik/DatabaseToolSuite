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

            TreeNode databaseNode = databaseTreeView.Nodes.Add("Database");

            foreach (DataTable table in dataSet.Tables)
            {
                TreeNode tableNode = databaseNode.Nodes.Add(table.TableName);
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

        }

        private void mnuFileExport_Click(object sender, EventArgs e)
        {
            OkatoEditDialog dialog = new OkatoEditDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void databaseTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           if (e.Node.Tag is DataTable)
            {
                mainDataGridView.DataSource = (DataTable)e.Node.Tag;
            }
        }
    }
}
