using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workHowToPlay : MonoBehaviour
{
 public Animator VirtualCam;
 public GameObject CanvasHowToPlay;
 public GameObject CanvasStart;
 public GameObject CanvasUi;
 private void Awake() {
    VirtualCam = GameObject.FindGameObjectWithTag("virtual").GetComponent<Animator>();
 }public void Off(){
    CanvasUi.SetActive(false);
    CanvasStart.SetActive(false);
 }public void On(){
    CanvasHowToPlay.SetActive(true);
 }public void AnimCamera(){
    VirtualCam.Play("cameraHowToPlay");
 }public void AnimCameraBefore(){
    VirtualCam.Play("CamerabeforeHowToPlay");
 }public void turnOff(){
        CanvasHowToPlay.SetActive(false);
 }public void turnOn(){
    CanvasUi.SetActive(true);
    CanvasStart.SetActive(true);
 }
}
