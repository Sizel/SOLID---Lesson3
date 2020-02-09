using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Fixed
{
    class NPC : Character
    {
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage * 2);
        }
    }
}
