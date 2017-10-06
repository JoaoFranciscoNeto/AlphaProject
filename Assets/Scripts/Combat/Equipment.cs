using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour {

    [HideInInspector]
    public bool Swinging = false;

    public string LeftAnimation
    {
        get;
        set;
    }

    public string RightAnimation
    {
        get;
        set;
    }

    // Use this for initialization
    void Start () {

        // Prevent self collision
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), transform.parent.GetComponentInParent<Collider2D>());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void OnMainBtnDown();

    public abstract void OnMainBtnUp();

    public abstract void OnSpecBtnDown();

    public abstract void OnSpecBtnUp();

    public abstract void OnEquip();

    public abstract void OnUnequip();

}
