using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DataModel.DAL
{
    public class DBHelper
    {
        public static void InitializeDB()
        {
            Database.SetInitializer<HumanResourceContext>
                (new InitializeHRDbWithSeedData());
        }
    }
}
