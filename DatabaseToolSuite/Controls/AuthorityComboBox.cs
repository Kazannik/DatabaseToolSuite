using DatabaseToolSuite.Repositoryes.Dto;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class AuthorityComboBox: ComboControl<AuthorityDto>
    {
        #region Initialize
        public  AuthorityComboBox() : base() { }

        [DebuggerNonUserCode()]
        public  AuthorityComboBox(IContainer container):base(container: container) { }

        public void InitializeSource(authorityDataTable table)
        {
            BeginUpdate();
            Items.Clear();
            foreach (authorityRow row in table.Rows)
            {
                Add(new AuthorityDto(row));
            }
            EndUpdate();
        }

        #endregion
    }
}
