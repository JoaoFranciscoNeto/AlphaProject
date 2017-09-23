using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public bool absoluteMovement = true;

    public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var fwdInput = Input.GetAxis("Vertical");
        var sideInput = Input.GetAxis("Horizontal");

        fwdInput = fwdInput * moveSpeed * Time.deltaTime;
        sideInput = sideInput * moveSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - mousePos, transform.forward), Time.deltaTime * moveSpeed * 2);
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        if (absoluteMovement)
            transform.Translate(sideInput, fwdInput, 0, Space.World);
        else
            transform.Translate(sideInput, fwdInput, 0, transform);
    }
}
