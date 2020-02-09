using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Failed
{
    class Program
    {
        public static void Main (string[] args)
        {
            DamageDealer damageDealer = new DamageDealer();
            NPC npc = new NPC();
            Player player = new Player();
            
            damageDealer.DealDamage(npc);
            Console.WriteLine(npc.Health);

            damageDealer.DealDamage(player);
            Console.WriteLine(player.Health);
        }
    }
}
