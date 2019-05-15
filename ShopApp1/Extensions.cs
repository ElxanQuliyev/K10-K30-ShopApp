using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp1
{
   static class Extensions
    {
        public static bool isNotEmpty(string[] values,string checkInput)
        {
            foreach (string a in values)
            {
                if(a== checkInput)
                {
                    return false;
                }
            }
            return true;
        }
        public static string hashMe(this string password)
        {
            byte[] byteArray = new ASCIIEncoding().GetBytes(password);
            byte[] hashArray = new SHA256Managed().ComputeHash(byteArray);
            string hashedPassword = new ASCIIEncoding().GetString(hashArray);
            return hashedPassword;


            

        }
    }
}
