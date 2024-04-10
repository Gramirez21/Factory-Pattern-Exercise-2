using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading Data From MongoDataAccess");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving Data to MongoDataaccess");
        }
    }
}
