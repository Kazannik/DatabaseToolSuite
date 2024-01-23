using System;
using System.Data;
using static DatabaseToolSuite.Repositoryes.RepositoryDataSet;

namespace DatabaseToolSuite.Services
{
    // Создание новой записи:
    // key++
    // version = key
    // index++

    // Создание версии записи:
    // key
    // version++
    // index
    static class MasterDataSystem
    {
        public static readonly DateTime MAX_DATE = new DateTime(2999, 12, 31);
        public static readonly DateTime MIN_DATE = new DateTime(1900, 1, 1);
        
        public static Repositoryes.RepositoryDataSet DataSet
        {
            get { return FileSystem.Repository.DataSet; }
        }
                
        /// <summary>
        /// Создание записи о подразделении правоохранительного органа
        /// </summary>
        /// <param name="name">Наименование подразделения</param>
        /// <param name="key"></param>
        /// <param name="okato"></param>
        /// <param name="authorityId"></param>
        /// <param name="code"></param>
        /// <param name="version"></param>
        /// <param name="index"></param>
        /// <param name="ownerKey"></param>
        /// <param name="dateBegin"></param>
        /// <param name="dateEnd"></param>
        /// <param name="courtTypeId"></param>
        /// <returns></returns>
        private static gaspsRow CreateOrganization(
            string name,
            long key,
            string okato,
            long authorityId,
            string code,
            long version,
            long index,
            long ownerKey,
            DateTime dateBegin,
            DateTime dateEnd,
            long courtTypeId)
        {
            object[] values = new object[14];
            values[0] = null; // id
            values[1] = name; // name
            values[2] = key; // key
            values[3] = okato; // okato_code
            values[4] = authorityId; // authority_id
            values[5] = code; // code
            values[6] = version; // version
            values[7] = index; // index
            values[8] = ownerKey; // owner_id
            values[9] = dateBegin; // date_beg
            values[10] = dateEnd; // date_end
            values[11] = null; // location_okato_id
            values[12] = null; // another_okato_id
            values[13] = 0; // court_type_id

            gaspsRow newRow = (gaspsRow) FileSystem.Repository.DataSet.gasps.Rows.Add(values);

            return newRow;
        }
       
        /// <summary>
        /// Создание новой записи.
        /// </summary>
        /// <param name="name">Наименование подразделения</param>
        /// <param name="okato">Код ОКАТО</param>
        /// <param name="authorityId">Индекс вида органа</param>
        /// <param name="code">Код подразделения</param>
        /// <param name="ownerKey">Ключ (key) родительского подразделения</param>
        /// <param name="dateBegin">Дата введения в действие новой записи</param>
        /// <param name="dateEnd">Дата окончания действия записи</param>
        /// <param name="courtTypeId">Индекс вида суда</param>
        /// <returns></returns>
        public static long CreateNewOrganization(
            string name,            
            string okato, 
            long authorityId,
            string code,
            long ownerKey,
            DateTime dateBegin,
            DateTime dateEnd,
            long courtTypeId)
        {
            long key = DataSet.gasps.GetNextKey();
            long version = DataSet.gasps.GetNextVersion();
            key = key >= version ? key : version;
            version = key;
            long index = DataSet.gasps.GetNextIndex();

            gaspsRow newRow = CreateOrganization(
                           name: name,
                           key: key,
                           okato: okato,
                           authorityId: authorityId,
                           code: code,
                           version: version,
                           index: index,
                           ownerKey: ownerKey,
                           dateBegin: dateBegin,
                           dateEnd: dateEnd,
                           courtTypeId: courtTypeId);

            return newRow.version;
        }
        
        /// <summary>
        /// Создание новой версии записи
        /// </summary>
        /// <param name="version">Индекс версии</param>
        /// <param name="date">Дата введения в действие новой версии</param>
        /// <param name="name">Наименование подразделения</param>
        /// <param name="okato">Код ОКАТО</param>
        /// <param name="authorityId">Индекс вида органа</param>
        /// <param name="ownerKey">Ключ (key) родительского подразделения</param>
        /// <param name="courtTypeId">Индекс вида суда</param>
        /// <returns></returns>
        public static long CreateNewVersionOrganization(
            long version, 
            DateTime date,
            string name,
            string okato,
            long authorityId,
            long ownerKey,            
            long courtTypeId)
        {
            gaspsRow modifedRow = DataSet.gasps.GetOrganizationFromVersion(version: version);

            if (!DataSet.gasps.IsLastVersion(version: version))
            {
                throw new ArgumentException(string.Format(
                    "Запись версии {0} не является самой последней записью с ключем {1}, поэтому не может быть отредактирована.",
                            version, modifedRow.key));
            }
            
            modifedRow.date_end = date;

            long newVersion = DataSet.gasps.GetNextVersion();

            gaspsRow newRow = CreateOrganization(
                name: name,
                key: modifedRow.key,
                okato: okato,
                authorityId: authorityId,
                code: modifedRow.code,
                version: newVersion,
                index: modifedRow.index,
                ownerKey: ownerKey,
                dateBegin: date,
                dateEnd: MAX_DATE,
                courtTypeId: courtTypeId);

            return newRow.version;
        }


        /// <summary>
        /// Создание новой версии записи
        /// </summary>
        /// <param name="version">Индекс версии</param>
        /// <param name="date">Дата введения в действие новой версии</param>
        /// <param name="name">Наименование подразделения</param>
        /// <returns></returns>
        public static long CreateNewVersionOrganization(
            long version,
            DateTime date,
            string name)
        {
            gaspsRow modifedRow = DataSet.gasps.GetOrganizationFromVersion(version: version);

            if (!DataSet.gasps.IsLastVersion(version: version))
            {
                throw new ArgumentException(string.Format(
                    "Запись версии {0} не является самой последней записью с ключем {1}, поэтому не может быть отредактирована.",
                            version, modifedRow.key));
            }

            modifedRow.date_end = date;

            long newVersion = DataSet.gasps.GetNextVersion();

            gaspsRow newRow = CreateOrganization(
                name: name,
                key: modifedRow.key,
                okato: modifedRow.okato_code,
                authorityId: modifedRow.authority_id,
                code: modifedRow.code,
                version: newVersion,
                index: modifedRow.index,
                ownerKey: modifedRow.owner_id,
                dateBegin: date,
                dateEnd: MAX_DATE,
                courtTypeId: modifedRow.court_type_id);

            return newRow.version;
        }

        /// <summary>
        /// Блокировка записи
        /// </summary>
        /// <param name="version">Индекс версии</param>
        /// <param name="date">Дата блокировки</param>
        public static void RemoveOrganization(long version, DateTime date)
        {
            gaspsRow oldRow = DataSet.gasps.GetOrganizationFromVersion(version: version);
            oldRow.BeginEdit();
            oldRow.date_end = date;
            oldRow.EndEdit();
        }
    }
}
