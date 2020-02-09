using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Fixed
{
    class Player : Character
    {
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage * 3);
        }
    }
}
