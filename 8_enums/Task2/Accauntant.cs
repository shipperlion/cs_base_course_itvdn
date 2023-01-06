using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Post
    {
        Manager = 200,
        Developer = 215,
        Secretary = 230,
        Cleaner = 190
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            else
                return false;
        }
    }
}
