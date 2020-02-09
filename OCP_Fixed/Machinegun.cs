using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Fixed
{
    class Machinegun : Weapon
    {
        override public void Shoot()
        {
            Console.WriteLine("You've been shot by machinegun!");
        }
    }
}
