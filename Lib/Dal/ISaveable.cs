using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    internal interface ISaveable
    {
        //bool IfFileExists();
        void SaveToFile();
        void LoadFromFile();
    }
}
