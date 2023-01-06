using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUser
{
    class User
    {
        string login, name, surname;
        int age;
        readonly string date;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            date = "today date";
        }

        public void ShowUser()
        {
            Console.WriteLine("Login: {0}\nName and surname: {1} {2}", login, name, surname);
            Console.WriteLine("Age: {0}\nDate of filling: {1}", age, date);
        }
    }
}
