using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DatabaseToolSuite.Controls
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(TextBox))]
    [ComVisible(false)]
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {

        }

        public NumericTextBox(IContainer container)
        {
            container.Add(this);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == 0)
                e.Handled = false;
            else if (e.KeyChar == '\b')
                e.Handled = false;
            else if (e.KeyChar == (0x0d))
                e.Handled = false;
            else if (e.KeyChar >= 48 & e.KeyChar <= 57)
                e.Handled = false;
            else
                e.Handled = true;
            base.OnKeyPress(e);
        }


        public long Value
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Text)) return 0;
                long result = 0;
                if (long.TryParse(Text, out result))
                    return result;
                else                
                    return 0;
            }
        }       
    }
}

