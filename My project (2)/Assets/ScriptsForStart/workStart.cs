using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workStart : MonoBehaviour
{
    public GameObject CanvasStart;
    public GameObject CanvasUi;
    public GameObject CanvasLvl2;
    public GameObject CanvasLvl3;
    public void Starter(){
        CanvasStart.SetActive(true);
    }private void Awake() {
        CanvasStart.SetActive(false);
        CanvasUi.SetActive(true);

    }public void Game2(){
        CanvasLvl2.SetActive(true);
    }public void Game3(){
        CanvasLvl3.SetActive(true);
    }
}
