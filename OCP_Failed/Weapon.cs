using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Failed
{
    class Weapon
    {
        public string weaponType { get; set; }
        public Weapon(string weaponType)
        {
            this.weaponType = weaponType;
        }
        public void Shoot()
        {
            if (weaponType.Equals("Laser"))
            {
                Console.WriteLine("You've been shot by a laser!");
            }
            else if (weaponType.Equals("Machinegun"))
            {
                Console.WriteLine("You've been shot by a machinegun!");
            }
        }
    }
}
