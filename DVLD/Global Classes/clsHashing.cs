using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD.Classes
{
    public  class clsHashing
    {
       public static string CreatePasswordHash(string Password)
        {
           
            using (SHA256 sha256 = SHA256.Create())
            {
                
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

        }

      

    }
}
