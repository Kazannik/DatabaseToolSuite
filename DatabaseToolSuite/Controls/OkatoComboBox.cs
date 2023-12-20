using DatabaseToolSuite.Repositoryes.Dto;
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

namespace DatabaseToolSuite.Controls
{
    public class OkatoComboBox: Base.ComboBoxBase
    {

        public void SetData(okatoDataTable table)
        {
            this.Clear();
            foreach (okatoRow row in table.Rows)
            {
                this.Add(new OkatoDto(row));
            }
        }

        
        public OkatoDto SelectedOkato
        {
            get
            {
                return ((OkatoItem)this.SelectedItem).Okato;
            }
        }
            

        #region Initialize
        public OkatoComboBox() : base() { }

        [System.Diagnostics.DebuggerNonUserCode()]
        public OkatoComboBox(IContainer container):base(container: container) { }


        [ReadOnly(true)]
        public new OkatoItem this[int index]
        {
            get
            {
                return (OkatoItem)base.Items[index: index];
            }
        }       

        protected void Insert(int index, OkatoItem item)
        {
            base.Items.Insert(index, item);
        }

        protected void Remove(OkatoItem value)
        {
            base.Items.Remove(value);
        }
       
        public int Add(OkatoItem item)
        {
            foreach (OkatoItem i in base.Items)
            {
                if (i.Code == item.Code)
                {
                    throw new ArgumentException("Элемент с кодом [" + item.Code.ToString() + "] ранее добавлен в коллекцию.", "item.Code");
                }
            }
            return base.Items.Add(item);
        }

        public override int Add(string code, string text)
        {
           return 0;
        }

        public int Add(OkatoDto okato)
        {
            return this.Add(new OkatoItem(okato));
        }

        #endregion

        public class OkatoItem : IComboBoxItem
        {
            public OkatoItem(OkatoDto okato)
            {
                this.Okato = okato;
                this.Code = okato.Code;
                this.Text = okato.Name;
            }

            public string Code { get; }
            public string Text { get; }
            public OkatoDto Okato { get; }
        }
    }
}
