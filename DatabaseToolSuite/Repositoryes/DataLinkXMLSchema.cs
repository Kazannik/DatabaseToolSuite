using System;
using System.Data;
using System.Linq;

namespace DatabaseToolSuite.Repositoryes
{

    partial class LinkDataSet
    {


        partial class DecimalLinkTableDataTable
        {
            public bool ExistsSourceId(Int64 id)
            {
                return (from item in this.AsEnumerable()
                        where item.source_table_key == id
                        select item).Count() == 1;
            }

            public bool ExistsLinkId(string id)
            {
                return (from item in this.AsEnumerable()
                        where item.link_table_key == id
                        select item).Count() == 1;
            }


            public Int64 GetSourceId(string linkId)
            {
                return (from item in this.AsEnumerable()
                        where item.link_table_key == linkId
                        select item).First().source_table_key;
            }

            public string GetLinkId(Int64 sourceId)
            {
                return (from item in this.AsEnumerable()
                        where item.source_table_key == sourceId
                        select item).First().link_table_key;
            }
        }

        partial class StringLinkTableDataTable
        {
            public bool ExistsSourceId(string id)
            {
                return (from item in this.AsEnumerable()
                        where item.source_table_key == id
                        select item).Count() == 1;
            }

            public bool ExistsLinkId(string id)
            {
                return (from item in this.AsEnumerable()
                        where item.link_table_key == id
                        select item).Count() == 1;
            }


            public string GetSourceId(string linkId)
            {
                return (from item in this.AsEnumerable()
                        where item.link_table_key == linkId
                        select item).First().source_table_key;
            }

            public string GetLinkId(string sourceId)
            {
                return (from item in this.AsEnumerable()
                        where item.source_table_key == sourceId
                        select item).First().link_table_key;
            }
        }
    }
}
