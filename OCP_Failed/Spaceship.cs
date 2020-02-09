using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Failed
{
    class Spaceship
    {
        public Weapon weapon;
        public Spaceship(string weaponType)
        {
            weapon = new Weapon(weaponType);
        }
    }
}
