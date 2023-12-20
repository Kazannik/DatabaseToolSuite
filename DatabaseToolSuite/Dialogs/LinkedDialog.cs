using System;
using System.Data;
using System.Windows.Forms;

namespace DatabaseToolSuite.Dialogs
{
    public partial class LinkedDialog : Form
    {
        string[] _hideCodes = new string[] { };
        DataTable _table;
        int _codeColumnIndex;
        int _textColumnIndex;

        public LinkedDialog(string repositoryText, DataTable table, int codeColumnIndex, int textColumnIndex, string[] hideCodes)
        {
            RepositoryText = repositoryText;
            _table = table;
            _codeColumnIndex = codeColumnIndex;
            _textColumnIndex = textColumnIndex;
            _hideCodes = hideCodes;
            
            InitializeComponent();

            repositoryTextBox.Text = repositoryText;
            RefreshDataSource(table: _table, codeColumnIndex: _codeColumnIndex, textColumnIndex: _textColumnIndex, hideCodes: _hideCodes);            
        }

        public string RepositoryText { get; }

        public string SelectedCode
        {
            get
            {
                return dictionaryTableViewComboBox.SelectedCode;
            }
        }

        public string SelectedText
        {
            get
            {
                return dictionaryTableViewComboBox.SelectedText;
            }
        }

        private void hideLinkedItemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                RefreshDataSource(table: _table, codeColumnIndex: _codeColumnIndex, textColumnIndex: _textColumnIndex, hideCodes: _hideCodes);
            } else
            {
                RefreshDataSource(table: _table, codeColumnIndex: _codeColumnIndex, textColumnIndex: _textColumnIndex, hideCodes: null);
            }
        }


        private void RefreshDataSource(DataTable table, int codeColumnIndex, int textColumnIndex, string[] hideCodes)
        {
            if (hideCodes == null || hideCodes.Length == 0)
            {
                dictionaryTableViewComboBox.SetData(table: table, codeColumnIndex: codeColumnIndex, textColumnIndex: textColumnIndex);
            }
            else
            {
                dictionaryTableViewComboBox.SetData(table: table, codeColumnIndex: codeColumnIndex, textColumnIndex: textColumnIndex, hideCodes: hideCodes);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
