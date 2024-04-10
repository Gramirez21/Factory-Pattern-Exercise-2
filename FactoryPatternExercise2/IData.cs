using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal interface IDataAccess
    {
        public abstract void LoadData();

        public abstract void SaveData();


    }
}
