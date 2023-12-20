using DatabaseToolSuite.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DatabaseToolSuite.Controls
{
    public class TableViewComboBox: ComboBoxBase
    {
        public void SetData(DataTable table, int codeColumnIndex, int textColumnIndex)
        {
            SetData(table: table, codeColumnIndex: codeColumnIndex, textColumnIndex: textColumnIndex, hideCodes: new string[] { });
        }

        public void SetData(DataTable table, int codeColumnIndex, int textColumnIndex, string[] hideCodes)
        {
            this.Clear();
            IList<string> hideCollection = new List<string>(hideCodes);

            foreach (DataRow row in table.Rows)
            {
                DataRowItem newItem = new DataRowItem(row: row, codeColumnIndex: codeColumnIndex, textColumnIndex: textColumnIndex);
                if (!hideCollection.Contains(newItem.Code))
                {
                    this.Add(newItem);
                }                
            }
        }
        
        public DataRow SelectedRow
        {
            get
            {
                return ((DataRowItem)this.SelectedItem).DataRow;
            }
        }
   
        #region Initialize
        public TableViewComboBox() : base() { }

        [System.Diagnostics.DebuggerNonUserCode()]
        public TableViewComboBox(IContainer container):base(container: container) { }
        
        [ReadOnly(true)]
        public new DataRowItem this[int index]
        {
            get
            {
                return (DataRowItem)base.Items[index: index];
            }
        }

        protected void Insert(int index, DataRowItem item)
        {
            base.Items.Insert(index, item);
        }

        protected void Remove(DataRowItem value)
        {
            base.Items.Remove(value);
        }

        public int Add(DataRowItem item)
        {
            foreach (DataRowItem i in base.Items)
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
            return this.Add(new DataRowItem(code: code, text: text));
        }

        internal int Add(DataRow row, int codeColumnIndex, int textColumnIndex)
        {
            return this.Add(new DataRowItem(row: row, codeColumnIndex: codeColumnIndex, textColumnIndex: textColumnIndex));
        }

        #endregion

        public class DataRowItem : IComboBoxItem
        {
            public DataRowItem(string code, string text)
            {
                this.DataRow = null;
                this.Code = code;
                this.Text = text;
            }

            internal DataRowItem(DataRow row, int codeColumnIndex, int textColumnIndex )
            {
                this.DataRow = row;
                this.Code = this.DataRow[codeColumnIndex].ToString();
                this.Text = this.DataRow[textColumnIndex].ToString();
            }

            public string Code { get; }
            public string Text { get; }
            public DataRow DataRow { get; }
        }
    }
}
