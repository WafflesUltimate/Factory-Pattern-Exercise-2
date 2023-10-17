using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {

        public static IDataAcces GetDataAcessType(string dataBaseType)
        { 
            switch(dataBaseType) 
            {
                case "list":
                    ListDataAccess listData = new ListDataAccess();
                    Console.WriteLine("Success, new List Data Access!");
                    return listData;
                case "sql":
                    SQLDataAccess sqlData = new SQLDataAccess();
                    Console.WriteLine("Success, new SQL Data Access!");
                    return sqlData;
                case "mongo":
                    MongoDataAccess mongoData = new MongoDataAccess();
                    Console.WriteLine("Success, new Mongo Data Access!");
                    return mongoData;
                default:
                    throw new NotImplementedException();

            }
        }

    }
}
