using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Fixed
{
    class Game
    {
        public static void Main(string[] args)
        {
            Laser laser = new Laser();
            Machinegun machinegun = new Machinegun();
            Spaceship spaceshipWithLaser = new Spaceship(laser);
            Spaceship spaceshipWithMachinegun = new Spaceship(machinegun);

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
