using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkberAli
{
    class Yesterday
    {
        public static string GUID()
        {
            return DateTime.Now.Year.ToString() + "-" +
                    DateTime.Now.Month.ToString() + "-" +
                    (DateTime.Now.Day-1).ToString();
        }
    }
}
