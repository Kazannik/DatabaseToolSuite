using DatabaseToolSuite.Repositoryes;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DatabaseToolSuite.Dialogs
{
    public partial class ImportProcessDialog : Form
    {
        DataTable _dataTable;
        string _filename;
        int[] _linkColumnIndex;
        DataTable[] _linkDataTables;
        

        public ImportProcessDialog(DataTable dataTable, string filename, int[] linkColumnIndexes) : this(dataTable: dataTable, filename: filename, linkColumnIndexes:linkColumnIndexes, linkDataTables: null) { }

        public ImportProcessDialog(DataTable dataTable, string filename, int[] linkColumnIndexes,  DataTable[] linkDataTables)
        {
            _dataTable = dataTable;
            _filename = filename;
            _linkDataTables = linkDataTables;

            InitializeComponent();

            progressLabel.Text = String.Empty;
            cancelButton.Enabled = true;            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            importBackgroundWorker.CancelAsync();
            cancelButton.Enabled = false;
        }

        private void importBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            DataTable dataTable =(DataTable) ((Object[])e.Argument)[0];
            string filename = (string)((Object[])e.Argument)[1];
            DataTable[] linkDataTables = (DataTable[])((Object[])e.Argument)[2];

         
            //LinkDataSet linkDataSet = new LinkDataSet();
            //if (linkfile !=string.Empty)
            //{
            //    linkDataSet.ReadXml(linkfile, XmlReadMode.IgnoreSchema);
            //}

            StreamReader reader = new StreamReader(filename, Encoding.GetEncoding(1251));
            long length = reader.BaseStream.Length;
            string headers = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                long percent = reader.BaseStream.Position * 100 / length;
                worker.ReportProgress((int)percent);
                string line = reader.ReadLine();
                string[] split = line.Split(';');

                object[] cells = new object[dataTable.Columns.Count];

                for (int i = 0; i < split.Length; i++)
                {
                    if (linkDataTables[i] == null)
                    {
                        try
                        {
                            cells[i] = Convert.ChangeType(split[i], dataTable.Columns[i].DataType);
                        }
                        catch (Exception)
                        {
                            cells[i] = 0;
                        }                        
                    } else
                    {

                    }
                }

                DataRow row =  dataTable.Rows.Add(cells);
            }

            reader.Close();

            e.Result = "100%";
        }

        private void importBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.importProgressBar.Value = e.ProgressPercentage;
        }

        private void importBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {                
                progressLabel.Text = "Canceled";
                Close();
            }
            else
            {
                progressLabel.Text = e.Result.ToString();
                Close();
            }
            cancelButton.Enabled = false;
        }

        private void ImportProcessDialog_Shown(object sender, EventArgs e)
        {
            if (_linkDataTables == null)
            {
                _linkDataTables = new DataTable[_dataTable.Columns.Count];
            }

            importBackgroundWorker.RunWorkerAsync(new object[] { _dataTable, _filename, _linkDataTables});
        }
    }
}
