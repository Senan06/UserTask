using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Models
{
    public class User
    {
        private string _userName;
        private string _password;
        private int _age;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value != "")
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Username bos ola bilmez!");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == "null")
                {
                    Console.WriteLine("Password bos ola bilmez");
                }
                else if (value.Length < 9)
                {
                    Console.WriteLine("Password 8 simoldan boyuk olmalidir");

                }
                else if (UpChars(value) == 0)
                {
                    Console.WriteLine("Password Minimum 1 reqem ve 1 boyuk simvol olmalidir");
                }
                else
                {
                    _password = value;
                }
            }

        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Yas Musbet eded olmalidir!");
                }
            }
        }
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public User(string UserName, string Password, int Age):this(UserName, Password)
        {
            this.Age = Age;
        }
        private int UpChars(string password)
        {
            int say = 0, say1 = 0;
            for (int i = 0; i < password.Length; i++)
            {

                if (Char.IsUpper(password[i]))
                {
                    say++;
                }
                if (Char.IsNumber(password[i]))
                {
                    say1++;
                }

            }
            //	Console.WriteLine(say);
            return (say - say1) * say1;
        }
    }
}
