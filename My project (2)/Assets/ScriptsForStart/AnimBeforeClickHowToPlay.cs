using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBeforeClickHowToPlay : MonoBehaviour
{
    public Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }public void AnimationHowToPlay(){
        anim.Play("howPlayAnimation");
    }
}
