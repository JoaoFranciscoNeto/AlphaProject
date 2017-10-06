using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat {

    public class ActorHealthState : MonoBehaviour, IDamagable {

        public int MaxHitPoints;
        int currentHitPoints;

        public void TakeDamageFrom(IDamager damager)
        {
            currentHitPoints -= damager.Damage;

            Debug.Log("Took " + damager.Damage + " damage");
        }

        // Use this for initialization
        void Start() {
            currentHitPoints = MaxHitPoints;
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
