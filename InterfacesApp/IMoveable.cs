using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp
{
    internal interface IMoveable
    {
        void Move5();

        void Move18()
        {
            Console.WriteLine("Moving 18 steps.");
        }
    }
}
