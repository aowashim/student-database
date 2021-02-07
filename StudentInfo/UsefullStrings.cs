using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class UsefullStrings
    {
        public static String GetString()
        {
            return "server=OWASHIM\\SQLEXPRESS; initial catalog=soe; user id=owashim; password=12345";
        }

        public static String ErrorString()
        {
            return "An error has occurred at the database...\nMake sure that you haven't entered any invalid data..." +
                "\n\nDetails below :\n";
        }
    }
}
