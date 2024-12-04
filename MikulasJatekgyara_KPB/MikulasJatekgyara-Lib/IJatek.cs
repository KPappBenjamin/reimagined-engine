using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public interface IJatek
    {
        string Azonosito { get; }
        string Tipus {  get; }
        string Megnevezes { get; }
        int ElkeszitesiIdo { get; }
    }
}
