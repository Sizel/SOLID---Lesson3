using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Fixed
{
    class Spaceship
    {
        public Weapon weapon { get; set; }
        public Spaceship(Weapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
