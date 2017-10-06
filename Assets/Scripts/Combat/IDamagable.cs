using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public interface IDamagable
    {
        void TakeDamageFrom(IDamager damager);
    }
}

