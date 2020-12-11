using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Enums
{
    public enum Directions
    {
        [Description("Kuzey")]
        N,
        [Description("Doğu")]
        E,
        [Description("Güney")]
        S,
        [Description("Batı")]
        W
    }
}
