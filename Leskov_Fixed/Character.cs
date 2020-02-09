using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Fixed
{
    class Character
    {
        public int Health { get; set; } = 100;

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
