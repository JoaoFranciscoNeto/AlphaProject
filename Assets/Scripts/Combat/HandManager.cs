using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour {

    public bool Swinging = false;
    public Equipment Equiped;

    void Start()
    {
        Equiped = GetComponentInChildren<Equipment>();
    }

    // Update is called once per frame
    void Update () {

        Equiped.Swinging = Swinging;
	}
}
