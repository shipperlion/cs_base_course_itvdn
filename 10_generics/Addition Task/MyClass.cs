﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Task
{
    class MyClass<T> where T: new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
