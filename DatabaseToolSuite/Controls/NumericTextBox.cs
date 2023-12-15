using System.ComponentModel;
using System.Windows.Forms;

namespace DatabaseToolSuite.Controls
{
    public partial class NumericTextBox : System.Windows.Forms.TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        public NumericTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
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


        public double Value
        {
            get
            {
                if (this.Text.Trim().Length == 0) return 0;
                double dbl = 0;
                bool result = double.TryParse(this.Text, out dbl);
                if (result)
                    return dbl;
                else
                    return 0;
            }
        }        
    }
}

