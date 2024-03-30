using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }
    public void RestartScene(){
        SceneManager.LoadScene("Game");
    }
    private void Update() {
    if(Input.GetKey(KeyCode.R)){
        anim.Play("Restarter");
    } 
    }public void InMenu(){
        SceneManager.LoadScene("StartScene");
    }public void InsMeth(){
        anim.Play("inMenu");
    }public void lvlManager(){
        SceneManager.LoadScene("lvls");
    }public void InMenuMeth(){
        anim.Play("InMenuAnim");
    }public void AnimPlay1Lvl(){
        anim.Play("animStartGame");
    }    public void Gamee2(){
        SceneManager.LoadScene("Game2");
    }public void AnimPlay2Lvl(){
        anim.Play("AnimStartGame2");
    } public void Gamee3(){
        SceneManager.LoadScene("Game3");
    }public void AnimPlay3Lvl(){
        anim.Play("AnimStartGame3");
    }
}