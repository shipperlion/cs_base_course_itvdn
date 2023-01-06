using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Player: IRecodable, IPlayable
    {
        public void Play() { Console.WriteLine("Play music"); }
        void IPlayable.Pause() { Console.WriteLine("Pause music"); }
        void IPlayable.Stop() { Console.WriteLine("Stop music"); }


        public void Record() { Console.WriteLine("Record music"); }
        void IRecodable.Pause() { Console.WriteLine("Pause record"); }
        void IRecodable.Stop() { Console.WriteLine("Stop record"); }
    }
}
