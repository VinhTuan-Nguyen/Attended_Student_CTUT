using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DX_Application
{
    class Shared
    {
        public bool Pass_Macth(string pass, string repass)
        {
            if (pass == repass) return true;
            else return false;
        }

        public bool CheckRegex(string pass)
        {
            if (!Regex.IsMatch(pass, @"^[0-9a-zA-Z]{8,}$")
                && !Regex.IsMatch(pass, @"^[0-9a-zA-Z]{8,}$"))
            {
                return false;
            }
            else return true;
        }

        public bool CheckUser(string userID)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                var result = db.tb_Accounts.Find(userID);
                if (result != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool CheckStudent(string ID)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                var result = db.tb_Students.Find(ID);
                if (result != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public string Encode(string password)
        {
            String str = "";
            Byte[] buffer = Encoding.UTF8.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("x");
            }
            return str;
        }
    }
}
