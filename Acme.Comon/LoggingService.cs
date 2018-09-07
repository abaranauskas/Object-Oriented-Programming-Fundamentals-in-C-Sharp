using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Comon
{
    public class LoggingService
    {
        public static void WriteToFlie(List<ILoggable> changeItems)
        {
            foreach (var item in changeItems)
            {

                Console.WriteLine(item.Log());
            }
        }
    }
}
