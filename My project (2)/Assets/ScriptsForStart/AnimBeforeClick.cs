using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBeforeClick : MonoBehaviour
{
    public Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }public void Animation(){
        anim.Play("AnimClik");
    }
}
