using DatabaseToolSuite.Controls;
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
        public string Code { get; private set; }

        public string Okato { get; private set; }

        public int Ter { get; private set; }

        public int Kod1 { get; private set; }

        public string Lab { get; private set; }

        public string OkatoName { get; private set; }

        public string OkatoName2 { get; private set; }

        public string OkatoCentrum { get; private set; }

        public string OkatoGenitive { get; private set; }
        
        public OkatoEditDialog()
        {
            InitializeComponent();
        }

        public OkatoEditDialog(int ter, int kod1, string lab, string name, string name2, string centrum, string genitive)
        {
            InitializeComponent();

            terNumericTextBox.Text = ter.ToString("0");
            kod1NumericTextBox.Text = kod1.ToString("0");
            labTextBox.Text = lab;
            nameTextBox.Text = name;
            name2TextBox.Text = name2;
            centrumTextBox.Text = centrum;
            genitiveTextBox.Text = genitive;
            SetCode();
        }


        private void terNumericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            int ter = 0;
            int.TryParse(control.Text, out ter);
            Ter = ter;
            SetCode();
        }

        private void kod1NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            int kod1 = 0;
            int.TryParse(control.Text, out kod1);
            Kod1 = kod1;
            SetCode();
        }

        private void labTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            Lab = control.Text;
            SetCode();
        }

        private void SetCode()
        {
            Okato = terNumericTextBox.Value.ToString("00") + (kod1NumericTextBox.Value > 0 ? kod1NumericTextBox.Value.ToString("00"):string.Empty);
            Code = Okato + (labTextBox.Text.Length > 0 ? labTextBox.Text.ToUpper() : string.Empty);
            okatoTextBox.Text = Okato;
            codeTextBox.Text = Code;
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
