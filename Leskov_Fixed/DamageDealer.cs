using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Fixed
{
    class DamageDealer
    {
        private int damage = 15;
        public void DealDamage(Character character)
        {
            character.TakeDamage(damage);
        }
    }
}
