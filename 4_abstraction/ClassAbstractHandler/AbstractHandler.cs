using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractHandler
{
    abstract class AbstractHandler
    {
        public abstract void Create();
        public abstract void Open();
        public abstract void Change();
        public abstract void Save();
    }
}
