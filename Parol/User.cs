using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parol
{
    internal class User
    {
        public string UserName { get; set; }
        private string Password { get; set; }

        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public void SetPassword(string newPassword)
        {
            if (!DuzgunSifre(newPassword))
            {
                Console.WriteLine("Daha duzgun sifre girin.Minimum 8 karakter isledin");
            }
            Password = newPassword;
            Console.WriteLine("Şifre ugurla deyisdirildi");
            return;
        }
            public bool CheckPassword(string password)
        {
            return Password == password;
        }
        private bool DuzgunSifre(string password)
        {
            return password.Length >= 8;
        }
    }
}
