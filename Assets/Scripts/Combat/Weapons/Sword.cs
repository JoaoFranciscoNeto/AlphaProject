using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class Sword : Equipment, IDamager
    {
        public int Damage
        {
            get
            {
                return 10;
            }
        }
        

        // Use this for initialization
        void Start()
        {
            LeftAnimation = "1H_Sword_Swing_Left";
            RightAnimation = "1H_Sword_Parry_Right";
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(Swinging &&
                collision.transform.root != transform.root)

                collision.gameObject.GetInterfaceInParent<IDamagable>().TakeDamageFrom(this);
        }

        public override void OnMainBtnDown()
        {
            throw new NotImplementedException();
        }

        public override void OnMainBtnUp()
        {
            throw new NotImplementedException();
        }

        public override void OnSpecBtnDown()
        {
            throw new NotImplementedException();
        }

        public override void OnSpecBtnUp()
        {
            throw new NotImplementedException();
        }

        public override void OnEquip()
        {
            throw new NotImplementedException();
        }

        public override void OnUnequip()
        {
            throw new NotImplementedException();
        }
    }
}
