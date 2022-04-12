using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork
{
    class User
    {
        //Field
        private string _userName;
        //Property
        public string UserName 
        {
            get
            {
                return _userName;
            }
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("User Name Deyeri Minimum 8 simvol olmaldir !!!");
                    value = Console.ReadLine();
                }
                _userName = value;
            }
        }

        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                bool check = true;

                while (check)
                {
                    bool checkLower = false;
                    bool checkUpper = false;
                    bool checkDigit = false;

                    if (value.Length >=8)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }
                            else if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }

                            if (checkLower == true && checkUpper && checkDigit)
                            {
                                _password = value;
                                check = false;
                                break;
                            }
                        }

                        if (checkDigit == false || checkLower == false || checkUpper == false)
                        {
                            Console.WriteLine("Sifreni Duzgun Daxil Et:");
                            value = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sifre Minimum 8 simvol Olmalidir");
                        value = Console.ReadLine();
                    }
                }
            }
        }


        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
