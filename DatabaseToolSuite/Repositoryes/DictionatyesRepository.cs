using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseToolSuite.Repositoryes
{
    class DictionatyesRepository
    {
        DataSet dataSet;

        public DictionatyesRepository()
        {
            dataSet = new DataSet();
            dataSet.ReadXmlSchema("AuthorityDictionaryXMLSchema.xsd");
            dataSet.ReadXml("AuthorityDictionary.xml", XmlReadMode.IgnoreSchema);
            
   

        }

    }
}
