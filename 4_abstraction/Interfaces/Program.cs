using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            (player as IPlayable).Pause();

            player.Record();
            (player as IRecodable).Pause();

            Console.ReadKey();
        }
    }
}
