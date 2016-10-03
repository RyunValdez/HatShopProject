using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_2
{
    public class LoginValidator
    {
        public LoginValidator() { }

        public bool Validate(string uName, string password)
        {
            List<string> validUsernames = new List<string>(new string[] { "John", "Ryun", "Cole" });
            List<string> validPasswords = new List<string>(new string[] { "John123", "Ryun123", "Cole123" });

            foreach (string validUsername in validUsernames)
            {
                if (uName == validUsername)
                {
                    int index = validUsernames.IndexOf(validUsername);
                    if (password == validPasswords[index])
                    {
                        return true;
                    }
                    else
                    {
                        var errorPassword = MessageBox.Show("Input correct password");
                        return false;
                    }
                }
            }
            var errorUserList = MessageBox.Show("No users found with that username");
            return false;
        }
    }
}
