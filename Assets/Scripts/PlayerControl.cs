using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public bool absoluteMovement = true;

    public float moveSpeed = 10f;

    private Animation _animation;

    public HandManager rightHandManager;
    public HandManager leftHandManager;

    // Use this for initialization
    void Start()
    {
        _animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {


        if (!_animation.isPlaying)
        {
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
                _animation.Play(leftHandManager.Equiped.LeftAnimation);
            }

            if (Input.GetMouseButtonDown(1))
            {
                _animation.Play(rightHandManager.Equiped.RightAnimation);
            }

        }

    }
}
