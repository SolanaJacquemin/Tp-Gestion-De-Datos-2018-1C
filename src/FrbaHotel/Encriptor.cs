using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaHotel

{

    class Encriptor
    {
        public string Encrypt(string value)
        {
            using (SHA256Managed sha256hashstring = new SHA256Managed())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = sha256hashstring.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }

}
