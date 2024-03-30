using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAnimation : MonoBehaviour
{
    public Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }public void AnimaButton1(){
        anim.Play("clickAnimation");
    }
}
