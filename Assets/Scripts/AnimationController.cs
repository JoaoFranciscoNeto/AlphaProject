using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    Animation _animation;

    private void Start()
    {
        _animation = GetComponent<Animation>();
    }
    
    public void SwordParryStart()
    {
        _animation.Play("1H_Sword_Parry_Right");
    }
}
