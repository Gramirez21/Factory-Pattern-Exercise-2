using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
     static class DataAccessFactory
    {
        public static IDataAccess DataAccess(string userChoice)
        {
            switch (userChoice.ToLower())
            {
                case "list":
                    return new MongoDataAccess();
                case "mongo":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                default:
                    return new MongoDataAccess();
            }
        }
    }
}
