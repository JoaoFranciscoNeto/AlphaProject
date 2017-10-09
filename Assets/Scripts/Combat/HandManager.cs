using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Combat;

public class HandManager : MonoBehaviour {

    public bool Swinging = false;
    public Equipment Equiped;

    public enum Hand
    {
        LEFT,
        RIGHT
    }

    public Hand hand;

    void Start()
    {
        Equiped = GetComponentInChildren<Equipment>();
    }

    // Update is called once per frame
    void Update () {

        Equiped.Swinging = Swinging;
	}
}
