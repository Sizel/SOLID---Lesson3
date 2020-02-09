using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Failed
{
    class DamageDealer
    {
        private int damage = 15;
        public void DealDamage(Character character)
        {
            if (character is NPC)
            {
                damage *= 2;
            }
            else if (character is Player)
            {
                damage *= 3;
            }

            character.TakeDamage(damage);
        }
    }
}
