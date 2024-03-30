using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float speedRota;
    public moveJump script;
    public bool IsRotate;
    public float Angle;
    public bool theFirstJumpinfg;
    public float speedTheFrstJumping;
    private void Update() {
      if(script.IsGrounded == false && IsRotate && theFirstJumpinfg){
        Quaternion quat = Quaternion.AngleAxis(Angle,Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation,quat,speedTheFrstJumping * Time.deltaTime);
        theFirstJumpinfg = false;
        script.JumpForce = 1400;   
      }
       if(script.IsGrounded == false && IsRotate && !theFirstJumpinfg){
          Quaternion q = Quaternion.AngleAxis(Angle,Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation,q,speedRota* Time.deltaTime);
       }
       
        
    }private void Awake() {
        script = GetComponent<moveJump>();
        IsRotate = false;
        theFirstJumpinfg = true;
        }
         private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("ground")){
            IsRotate = false;
         }
   }
            private void OnCollisionExit(Collision other) {
             if(other.gameObject.CompareTag("ground")){
                IsRotate = true;
            }
            if(transform.rotation == Quaternion.Euler(0,0,Angle) && other.gameObject.CompareTag("ground") && transform.rotation == Quaternion.Inverse(Quaternion.Euler(0,0,180))){
              transform.rotation = Quaternion.Euler(0,0,0);
          
             }

        }private void OnCollisionStay(Collision other) { 
            if(other.gameObject.CompareTag("ground")){
            IsRotate = false;
         }
        }private void OnTriggerStay(Collider other) {
         if(other.gameObject.CompareTag("orb")){
         if(Input.GetMouseButton(0)){
            script.player.AddForce(new Vector2(script.player.velocity.x,200));
            Quaternion a = Quaternion.AngleAxis(Angle,Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,a,speedRota* Time.deltaTime);
         }
         }if(other.gameObject.CompareTag("jumper")){
         script.player.AddForce(new Vector2(script.player.velocity.x,1300));
         
         }
        }
}
//-63.16961
//10.26429