using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public bool absoluteMovement = true;

    public float moveSpeed = 10f;

    private Animator _animator;

	// Use this for initialization
	void Start () {

        _animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            _animator.applyRootMotion = true;
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


            if (Input.GetMouseButtonDown(0))
            {
                _animator.SetTrigger("1H_Sword_Swing");
            }
        } else
        {

            _animator.applyRootMotion = false;
        }
    }
}
