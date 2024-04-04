using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public static class Extension
    {

        public static bool PasswordChecker(this string password)
        {

            if(password.Length > 7 && !String.IsNullOrEmpty(password) && !String.IsNullOrWhiteSpace(password))
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i]))
                    {
                        isDigit = true;
                    }
                    else if (Char.IsUpper(password[i]))
                    {
                        isUpper = true;
                    }
                    else if (Char.IsLower(password[i]))
                    {
                        isLower = true;
                    }
                    if(isDigit && isUpper && isLower)
                        return true;
                }
            }

            return false;
        }
        public static bool UsernameChecker(this string username , Db db)
        {
            var data = db.Users.FirstOrDefault(x=>x.UserName == username);

            if(data == null)
            {
                return true;
            }
            return false;
        }

    }
}
