using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSide
{
    public static class DAL
    {
        public static IDataReader GetData(Database db, int value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"select * from ldb1_country_sites where fsiteid=:siteid");

            DbCommand dbCommand = db.GetSqlStringCommand(stringBuilder.ToString());

            dbCommand.CommandType = CommandType.Text;

            db.AddInParameter(dbCommand, ":siteid", DbType.Int32,value);

            return db.ExecuteReader(dbCommand);
        }
    }
}
