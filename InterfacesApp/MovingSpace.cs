using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfacesApp
{
    internal class MovingSpace
    {
        public IMoveable? Moveable { get; set; }

        public MovingSpace(IMoveable moveable)
        {
            Moveable = moveable;
        }

        public void Move5()
        {
            Moveable!.Move5();
        }
    }
}
