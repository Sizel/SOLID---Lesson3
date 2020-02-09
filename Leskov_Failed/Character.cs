using System;
using System.Collections.Generic;
using System.Text;

namespace Leskov_Failed
{
    class Character
    {
        public int Health { get; set; } = 100;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
