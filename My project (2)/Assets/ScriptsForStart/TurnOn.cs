using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    public GameObject CanvasStart;
    private void Awake() {
        CanvasStart.SetActive(true);
    }
}
