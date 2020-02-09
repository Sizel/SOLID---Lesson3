using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Fixed
{
    class Program
    {
        public static void Main (string[] args)
        {
            DamageDealer damageDealer = new DamageDealer();
            Character npc = new NPC();
            Character player = new Player();
            
            damageDealer.DealDamage(npc);
            Console.WriteLine(npc.Health);

            damageDealer.DealDamage(player);
            Console.WriteLine(player.Health);
        }
    }
}
