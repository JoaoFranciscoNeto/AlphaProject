using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour {

    [HideInInspector]
    public bool Swinging = false;

    protected HandManager.Hand equipedOn;

    // Use this for initialization
    void Start () {

        // Prevent self collision
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), transform.parent.GetComponentInParent<Collider2D>());
        
        equipedOn = GetComponentInParent<HandManager>().hand;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void OnMainBtnDown(Animation anim);

    public abstract void OnMainBtnUp(Animation anim);

    public abstract void OnSpecBtnDown(Animation anim);

    public abstract void OnSpecBtnUp(Animation anim);

    public abstract void OnEquip();

    public abstract void OnUnequip();

}
