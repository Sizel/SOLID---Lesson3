using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Failed
{
    class Game_f
    {
        public static void Main(string[] args)
        {
            Spaceship spaceshipWithLaser = new Spaceship("Laser");
            Spaceship spaceshipWithMachinegun = new Spaceship("Machinegun");

            List<Spaceship> spaceships = new List<Spaceship>();
            spaceships.Add(spaceshipWithLaser);
            spaceships.Add(spaceshipWithMachinegun);

            foreach (var spaceship in spaceships)
            {
                spaceship.weapon.Shoot();
            }
        }
    }
}
