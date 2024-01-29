using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;


namespace DatabaseToolSuite.Repositoryes
{


    partial class RepositoryDataSet
    {
        public bool ExistsCourtTypeId(Int64 id)
        {
            court_typeDataTable okato = (court_typeDataTable)this.Tables["court_type"];
            return court_type.ExistsId(id);
        }

        public bool ExistsCourtTypeName(string name)
        {
            court_typeDataTable okato = (court_typeDataTable)this.Tables["court_type"];
            return court_type.ExistsName(name);
        }

        public string GetCourtTypeName(Int64 id)
        {
            court_typeDataTable okato = (court_typeDataTable)this.Tables["court_type"];
            return court_type.GetName(id);
        }

        public bool ExistsOkatoCode(string code)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.ExistsCode(code);
        }

        public bool ExistsOkatoName(string name)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.ExistsName(name);
        }

        public bool ExistsOkatoName2(string name2)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.ExistsName2(name2);
        }

        public bool ExistsOkatoCentrum(string centrum)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.ExistsCentrum(centrum);
        }

        public bool ExistsOkatoGenitive(string genitive)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.ExistsGenitive(genitive);
        }

        public string GetOkatoName(string code)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.GetName(code);
        }

        public string GetOkatoName2(string code)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.GetName2(code);
        }

        public string GetOkatoGenitive(string code)
        {
            okatoDataTable okato = (okatoDataTable)this.Tables["okato"];
            return okato.GetGenitive(code);
        }

        partial class court_typeDataTable
        {
            public bool ExistsId(Int64 id)
            {
                return (from item in this.AsEnumerable()
                        where item.id == id
                        select item).Count() == 1;
            }

            public bool ExistsName(string name)
            {
                return (from item in this.AsEnumerable()
                        where item.name == name
                        select item).Count() == 1;
            }

            public string GetName(Int64 id)
            {
                return (from item in this.AsEnumerable()
                        where item.id == id
                        select item).First().name;
            }
        }

        partial class gaspsDataTable
        {

            public bool ExistsCode(string code)
            {
                return (from item in this.AsEnumerable()
                        where item.code.Equals(code, StringComparison.CurrentCultureIgnoreCase)
                        select item).Count() > 0;
            }

            public IList<gaspsRow> GetOrganizationFilter(long? authority, string okato, string code, string name, bool unlockShow, bool reserveShow, bool lockShow)
            {
                return _GetOrganizationFilter(authority: authority,
                    okato: okato,
                    code: code,
                    name: name,
                    unlockShow: unlockShow,
                    reserveShow: reserveShow,
                    lockShow: lockShow).ToList();
            }

            private IEnumerable<gaspsRow> _GetOrganizationFilter(long? authority, string okato, string code, string name, bool unlockShow, bool reserveShow, bool lockShow)
            {
                IEnumerable<gaspsRow> result = this.AsEnumerable()
                    .OrderBy(x => x.version).OrderBy(x => x.code);

                if (!unlockShow)
                {
                    result = result
                        .Where(x => (
                    (x.date_end < DateTime.Now || x.date_beg >= DateTime.Today))
                    );
                }

                if (!reserveShow)
                {
                    result = result
                    .Where(x => x.date_beg < DateTime.Today);
                }

                if (!lockShow)
                {
                    result = result
                    .Where(x => x.date_end > DateTime.Today);
                }

                if (authority.HasValue)
                {
                    result = result.Where(x => x.authority_id == authority.Value);
                }

                if (!string.IsNullOrWhiteSpace(okato))
                {
                    result = result.Where(x => x.okato_code.Equals(okato, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(code))
                {
                    result = result.Where(x => x.code.Contains(code));
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    result = result.Where(x => x.name.ToLower().Contains(name.ToLower()));
                }

                return result;
            }

            public IEnumerable<gaspsRow> GetOwnerOrganization()
            {
                return this.AsEnumerable().Where(x => x.owner_id == 0);
            }

            public DataView GetUnlockOrganization()
            {
                DataViewManager vm = new DataViewManager(this.DataSet);

                DataView dv = vm.CreateDataView(this);

                dv.RowFilter = string.Format("(date_beg <= {0} and date_end > {0}) or date_beg >= {0}", DateTime.Today.ToString("#MM-dd-yyyy#"));

                return dv;
            }

            public IList<gaspsRow> GetLockLastCodes(long? authority, string okato)
            {
                IEnumerable<gaspsRow> result = this.AsEnumerable()
                    .GroupBy(x => x.code, (key, g) => g.OrderByDescending(y => y.version).First())
                    .Where(x => x.date_end < DateTime.Today);

                if (authority.HasValue)
                {
                    result = result.Where(x => x.authority_id == authority.Value);
                }

                if (!string.IsNullOrWhiteSpace(okato))
                {
                    result = result.Where(x => x.okato_code.Equals(okato, StringComparison.OrdinalIgnoreCase));
                }

                return result.ToList();
            }

            public gaspsRow GetOrganizationFromVersion(long version)
            {
                return this.AsEnumerable()
                    .Last(x => x.version.Equals(version));
            }

            public gaspsRow GetLastVersionOrganizationFromKey(long key)
            {
                long version = this.AsEnumerable()
                    .Where(x => x.key.Equals(key)).Max(r => r.version);
                return GetOrganizationFromVersion(version);
            }

            public gaspsRow GetLastVersionOrganizationFromCode(string code)
            {
                long version = this.AsEnumerable()
                    .Where(x => x.code.Equals(code, StringComparison.CurrentCultureIgnoreCase)).Max(r => r.version);
                return GetOrganizationFromVersion(version);
            }


            public int GetEditedRowCount()
            {
                DateTime beginDate = new DateTime(2023, 01, 01);
                DateTime endDate = new DateTime(2023, 12, 31);
                return this.AsEnumerable()
                    .Where(x => (x.date_beg >= beginDate && x.date_beg <= endDate) || (x.date_end >= beginDate && x.date_end <= endDate))
                    .Count();
            }

            public string GetOrganizationName(long key, string defaultName)
            {
                try
                {
                    return GetLastVersionOrganizationFromKey(key).name;
                }
                catch (Exception)
                {
                    return defaultName;
                }
            }

            public bool IsLastVersion(long version)
            {
                gaspsRow current = GetOrganizationFromVersion(version);
                gaspsRow last = GetLastVersionOrganizationFromCode(current.code);
                return version.Equals(last.version);
            }

            public long GetNextKey()
            {
                if (this.Count > 0)
                    return 1 + this.AsEnumerable().Max(r => r.key);
                else
                    return 1;
            }

            public long GetNextVersion()
            {
                if (this.Count > 0)
                    return 1 + this.AsEnumerable().Max(r => r.version);
                else
                    return 1;
            }

            public long GetNextIndex()
            {
                if (this.Count > 0)
                    return 1 + this.AsEnumerable().Max(r => r.index);
                else
                    return 1;
            }

            public string GetNextCode(long authority, string okato)
            {
                string leftCode = authority.ToString("00") + okato;
                string rightCodeFormat = new string('0', 8 - leftCode.Length);

                if (this.AsEnumerable()
                    .Where(r => r.authority_id == authority && r.okato_code == okato).Count() > 0)
                {
                    long code = 1 + this.AsEnumerable()
                    .Where(r => r.authority_id == authority && r.okato_code == okato).Max(r => long.Parse(r.code.Substring(leftCode.Length)));

                    if (code.ToString().Length > rightCodeFormat.Length)
                    {
                        throw new ArgumentOutOfRangeException(
                            string.Format("Диапазон кодов исчерпан. Присваемое значение {0} выходит за границы заданного диапазона (1-{1}).",
                            code, new string('9', rightCodeFormat.Length))
                            );
                    }
                    else
                    {
                        return leftCode + code.ToString(rightCodeFormat);
                    }
                }
                else
                {
                    return leftCode + (1).ToString(rightCodeFormat);
                }
            }

            public IEnumerable<long> GetSkippedCodes(long authority, string okato)
            {
                string leftCode = authority.ToString("00") + okato;
                string rightCodeFormat = new string('0', 8 - leftCode.Length);
                List<long> codes = new List<long>(this.AsEnumerable()
                    .Where(r => r.authority_id == authority && r.okato_code == okato)
                    .Select(r => long.Parse(r.code.Substring(leftCode.Length)))
                    .Distinct());
                long length = rightCodeFormat.Length == 2 ? 99 : 9999;
                List<long> result = new List<long>();
                for (long i = 1; i < length; i++)
                {
                    if (!codes.Contains(i))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }

            public string GetNextSkippedCode(long authority, string okato)
            {
                string leftCode = authority.ToString("00") + okato;
                string rightCodeFormat = new string('0', 8 - leftCode.Length);
                long code = GetSkippedCodes(authority, okato).Min();
                return leftCode + code.ToString(rightCodeFormat);
            }

            public IEnumerable<long> GetUsedCodes(long authority, string okato)
            {
                string leftCode = authority.ToString("00") + okato;
                string rightCodeFormat = new string('0', 8 - leftCode.Length);
                List<long> codes = new List<long>(this.AsEnumerable()
                    .Where(r => r.authority_id == authority && r.okato_code == okato)
                    .Select(r => long.Parse(r.code.Substring(leftCode.Length)))
                    .Distinct());
                codes.Sort();
                return codes;
            }

            public BindingList<gaspsRow> GetLockCodes(long authority, string okato, DateTime today)
            {
                string leftCode = authority.ToString("00") + okato;
                string rightCodeFormat = new string('0', 8 - leftCode.Length);

                EnumerableRowCollection<gaspsRow> unlickCodes = from item in this.AsEnumerable()
                                                                where item.authority_id == authority &&
                                                                item.okato_code == okato &&
                                                                ((item.date_beg <= today &&
                                                                item.date_end > today) ||
                                                                item.date_beg > today)
                                                                orderby item.date_beg descending
                                                                select item;

                IEnumerable<gaspsRow> lockCodes = (from item in this.AsEnumerable()
                                                   where item.authority_id == authority &&
                                                   item.okato_code == okato &&
                                                   item.date_end <= today
                                                   orderby item.date_beg descending
                                                   select item).GroupBy(x => x.code).Select(y => y.FirstOrDefault());

                return new BindingList<gaspsRow>(lockCodes.Where(p => unlickCodes.All(p2 => p2.code != p.code)).OrderBy(x => x.code).ToArray());
            }

            public IEnumerable<Organization> ExportData()
            {
                return from item in this.AsEnumerable()
                       where (item.date_beg <= DateTime.Today &&
                       item.date_end > DateTime.Today)
                       join authority in authorityTable on item.authority_id equals authority.id
                       join okato in okatoTable on item.okato_code equals okato.code
                       select new Organization(name: item.name, authority: authority.name, okato: okato.code + " - " + okato.name, code: item.code, begin: item.date_beg);
            }

            public class Organization
            {
                public string Name { get; }
                public string Authority { get; }
                public string Okato { get; }
                public string Code { get; }
                public DateTime Begin { get; }

                public Organization(string name, string authority, string okato, string code, DateTime begin)
                {
                    Name = name;
                    Authority = authority;
                    Okato = okato;
                    Code = code;
                    Begin = begin;
                }
            }

            private authorityDataTable authorityTable
            {
                get { return Services.MasterDataSystem.DataSet.authority; }
            }

            private okatoDataTable okatoTable
            {
                get { return Services.MasterDataSystem.DataSet.okato; }
            }
        }

        partial class authorityDataTable
        {
            public bool ExistsId(Int64 id)
            {
                return (from item in this.AsEnumerable()
                        where item.id == id
                        select item).Count() == 1;
            }

            public bool ExistsName(string name)
            {
                return (from item in this.AsEnumerable()
                        where item.name == name
                        select item).Count() == 1;
            }

            public string GetName(Int64 id)
            {
                return (from item in this.AsEnumerable()
                        where item.id == id
                        select item).First().name;
            }
        }

        partial class okatoDataTable
        {

            public bool ExistsCode(string code)
            {
                return (from item in this.AsEnumerable()
                        where item.code == code
                        select item).Count() == 1;
            }

            public bool ExistsName(string name)
            {
                return (from item in this.AsEnumerable()
                        where item.name == name
                        select item).Count() == 1;
            }

            public bool ExistsName2(string name2)
            {
                return (from item in this.AsEnumerable()
                        where item.name2 == name2
                        select item).Count() == 1;
            }

            public bool ExistsCentrum(string centrum)
            {
                return (from item in this.AsEnumerable()
                        where item.centrum == centrum
                        select item).Count() == 1;
            }

            public bool ExistsGenitive(string genitive)
            {
                return (from item in this.AsEnumerable()
                        where item.genitive == genitive
                        select item).Count() == 1;
            }

            public string GetName(string code)
            {
                return (from item in this.AsEnumerable()
                        where item.code == code
                        select item).First().name;
            }

            public string GetName2(string code)
            {
                return (from item in this.AsEnumerable()
                        where item.code == code
                        select item).First().name2;
            }

            public string GetGenitive(string code)
            {
                return (from item in this.AsEnumerable()
                        where item.code == code
                        select item).First().genitive;
            }
        }
    }
}

namespace DatabaseToolSuite.Repositoryes.RepositoryDataSetTableAdapters
{

    [DesignerCategoryAttribute("code")]
    [ToolboxItem(true)]
    [DataObject(true)]
    [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [HelpKeyword("vs.data.TableAdapter")]
    public partial class QueriesTableAdapter : Component
    {

        private IDbCommand[] _commandCollection;

        protected IDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        private void InitCommandCollection()
        {
            this._commandCollection = new IDbCommand[1];
            this._commandCollection[0] = new System.Data.OleDb.OleDbCommand();
            ((System.Data.OleDb.OleDbCommand)(this._commandCollection[0])).CommandType = CommandType.Text;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        public virtual object ScalarQuery()
        {
            System.Data.OleDb.OleDbCommand command = ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[0]));
            ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & ConnectionState.Open)
                        != ConnectionState.Open))
            {
                command.Connection.Open();
            }
            object returnValue;
            try
            {
                returnValue = command.ExecuteScalar();
            }
            finally
            {
                if ((previousConnectionState == ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null)
                        || (returnValue.GetType() == typeof(DBNull))))
            {
                return null;
            }
            else
            {
                return ((object)(returnValue));
            }
        }
    }
}