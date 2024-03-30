using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlSwitch : MonoBehaviour
{
    public GameObject[] LVLS;
    public void Lvl1(){
        LVLS[0].SetActive(true);
        LVLS[1].SetActive(false);
        LVLS[2].SetActive(false);
    }  public void Lvl2(){
        LVLS[0].SetActive(false);
        LVLS[1].SetActive(true);
        LVLS[2].SetActive(false);
    }
}
