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
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(Swinging &&
                collision.transform.root != transform.root)

                collision.gameObject.GetInterfaceInParent<IDamagable>().TakeDamageFrom(this);
        }

        public override void OnMainBtnDown(Animation anim)
        {
            
            anim.Play(equipedOn == HandManager.Hand.RIGHT ? "1H_Sword_Swing_Right" : "1H_Sword_Swing_Left");
        }

        public override void OnMainBtnUp(Animation anim)
        {
            throw new NotImplementedException();
        }

        public override void OnSpecBtnDown(Animation anim)
        {
            throw new NotImplementedException();
        }

        public override void OnSpecBtnUp(Animation anim)
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
