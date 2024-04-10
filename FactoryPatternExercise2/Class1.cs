using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am Reading data from SQL");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQL");
        }
    }
}
