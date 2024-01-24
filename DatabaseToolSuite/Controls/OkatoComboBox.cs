using DatabaseToolSuite.Repositoryes.Dto;
using System.ComponentModel;
using System.Diagnostics;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Controls
{
    public class OkatoComboBox: ComboControl<OkatoDto>
    {
        #region Initialize

        public OkatoComboBox() : base() { }

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

