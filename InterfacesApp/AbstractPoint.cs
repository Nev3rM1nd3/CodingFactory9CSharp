using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp
{
    internal abstract class AbstractPoint : IMoveable
    {
        public int X { get; set; }
        public void Move5()
        {
            X += 5;
        }

        public void Move18()
        {
            X += 18;
        }
    }
}
