using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUser
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("shipperlion", "Inha", "Ostrikova", 18);
            user.ShowUser();

            Console.ReadKey();
        }
    }
}
