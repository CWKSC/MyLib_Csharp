﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public interface IUpdatable
    {
        public void Update();
        public void Update<T>(T arg);
    }

}
