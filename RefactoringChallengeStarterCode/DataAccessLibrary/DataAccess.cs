using ConsoleApp;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLibrary
{
    public class DataAccess
    {
        public static void CreateUser(SystemUserModel user)
        {
            ConnectionFactory.GetConnection()
                .Execute("dbo.spSystemUser_Create", user, commandType: CommandType.StoredProcedure);
        }

        public static List<SystemUserModel> GetUsers(object Filter = null)
        {
            return Filter == null ? 
                ConnectionFactory.GetConnection()
                    .Query<SystemUserModel>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList() :
                ConnectionFactory.GetConnection()
                    .Query<SystemUserModel>("spSystemUser_GetFiltered",Filter, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
