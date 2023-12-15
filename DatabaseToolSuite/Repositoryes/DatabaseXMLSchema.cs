using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DatabaseToolSuite.Repositoryes
{
}

namespace DatabaseToolSuite.Repositoryes
{
}

namespace DatabaseToolSuite.Repositoryes
{
}

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
