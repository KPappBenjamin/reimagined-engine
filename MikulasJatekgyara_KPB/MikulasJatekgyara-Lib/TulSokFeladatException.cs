﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public class TulSokFeladatException : Exception
    {
        public TulSokFeladatException() 
            : base("Túl sok feladat, több mint 8 óra elkészíteni.") { }
    }
}
