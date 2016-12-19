using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardMask
{
    public static class Kata
    {
        public static void Main(string[] arg)
        {
            
        }
        // return masked string
        public static string Maskify(string cc)
        {
            if (cc == null)
                return null;
            else if (cc.Length < 4)
                return cc;
            else
            {

                string subString = cc.Substring(cc.Length - 4);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i< cc.Length-4; i++)
                    sb.Append("#");

                Console.WriteLine(subString + ","+ sb+"->"+ (sb+subString));
                return sb + subString;

            }
        }
    }

}
