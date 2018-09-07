using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string sourse)
        {
            string result = string.Empty;           
            if (!String.IsNullOrWhiteSpace(sourse))
            {
                foreach (char letter in sourse)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";                                              
                    }                   
                    result += letter;
                    //result = result.Trim();                  
                }               
            }

            return result;
        }
    }
}
