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
           public DataView GetUnlockOrganization()
            {
                DataViewManager vm = new DataViewManager(this.DataSet);

                DataView dv =  vm.CreateDataView(this);
                      
                dv.RowFilter=string.Format("(date_beg <= {0} and date_end > {0}) or date_beg >= {0}", DateTime.Today.ToString("#MM-dd-yyyy#"));

                return dv;
            }


            public BindingList<gaspsRow> GetAll()
            {
                
                return new BindingList<gaspsRow>(
                    this.AsEnumerable()
                    .Where(x => (x.date_beg <= DateTime.Now && x.date_end >= DateTime.Now)
                     && x.authority_id == 20).ToArray());
            }


            public gaspsRow GetOrganization(long key)
            {
                return this.First(r => r.key == key);
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

            //public ObservableCollection<gaspsRow> GetAll()
            //{
            //    return new ObservableCollection <gaspsRow>(
            //        this.AsEnumerable()
            //        .Where(x => (x.date_beg <= DateTime.Now && x.date_end >= DateTime.Now)
            //         && x.authority_id == 20));
            //}         

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