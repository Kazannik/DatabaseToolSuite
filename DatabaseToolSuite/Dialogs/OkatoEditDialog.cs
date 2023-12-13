using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseToolSuite.Dialogs
{
    public partial class OkatoEditDialog : DatabaseToolSuite.Dialogs.DictionaryEditDialog
    {

        public int OkatoId { get; private set; }
        public string OkatoCode { get; private set; }
        public string OkatoName { get; private set; }
        public string OkatoName2 { get; private set; }
        public string OkatoCentrum { get; private set; }
        public string OkatoGenitive { get; private set; }


        public OkatoEditDialog()
        {
            InitializeComponent();
        }

        public OkatoEditDialog(int id, string name, string name2, string centrum, string genitive)
        {
            InitializeComponent();

            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            name2TextBox.Text = name2;
            centrumTextBox.Text = centrum;
            genitiveTextBox.Text = genitive;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            try
            {
                int id = 0;
                bool isParse = int.TryParse(control.Text, out id);
                if (isParse)
                {
                    OkatoId = id;
                    OkatoCode = id.ToString("00");
                    codeTextBox.Text = OkatoCode;
                }
                else
                {
                    codeTextBox.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                codeTextBox.Text = string.Empty;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            OkatoName = control.Text;
        }

        private void name2TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            OkatoName2 = control.Text;
        }

        private void centrumTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            OkatoCentrum = control.Text;
        }

        private void genitiveTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            OkatoGenitive = control.Text;
        }
    }
}
