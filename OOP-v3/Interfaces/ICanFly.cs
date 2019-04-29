using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    interface ICanFly
    {
        int WingSpan { get; set; }
        int FlySpeed { get; set; }
        int CurrentFlyingSpeed { get; set; }

        void FlapWings();
        void Glide();
    }
}
