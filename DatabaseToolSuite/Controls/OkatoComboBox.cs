﻿using DatabaseToolSuite.Repositoryes.Dto;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Controls
{    
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class OkatoComboBox: ComboControl<OkatoDto>
    {
        #region Initialize

        public OkatoComboBox() : base() { }

        [DebuggerNonUserCode()]
        public OkatoComboBox(IContainer container):base(container: container) { }

        public void InitializeSource(okatoDataTable table)
        {
            BeginUpdate();
            Items.Clear();
            foreach (okatoRow row in table.Rows)
            {
                Add(new OkatoDto(row));
            }
            EndUpdate();
        }        

        #endregion
    }
}

