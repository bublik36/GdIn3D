using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveJump : MonoBehaviour
{
    public Rigidbody player;
    public float speed;
    public float JumpForce;
    public bool IsGrounded;

    private rotate RotObj;
    public GameObject ParticleSystemOne;
    public GameObject ParticleSystemTwo;
    public GameObject Canvasress;
    public GameObject CanvasWin;
    public GameObject CanvasStart;
    public GameObject CanvasMenu;









    private void Awake() {
        player = GetComponent<Rigidbody>();
        RotObj = GetComponent<rotate>();
        ParticleSystemOne.SetActive(false);
        ParticleSystemTwo.SetActive(false);
        Canvasress.SetActive(false);
        CanvasWin.SetActive(false);
        CanvasMenu.SetActive(false);


        
    }private void FixedUpdate() {
        player.velocity = transform.TransformDirection(new Vector2(-50 * speed * Time.fixedDeltaTime,player.velocity.y));
        
         if(transform.rotation.eulerAngles.z >= 45 && transform.rotation.eulerAngles.z < 180){
            player.velocity = transform.TransformDirection(new Vector2(player.velocity.x,50 * speed* Time.fixedDeltaTime));
        }else if(transform.rotation.eulerAngles.z >= 180){
             player.velocity = transform.TransformDirection(new Vector2(    50 * speed* Time.fixedDeltaTime,player.velocity.y));
        }

    }private void Update() {
        Jump();
        if(Input.GetKeyDown(KeyCode.Escape) && CanvasMenu.activeInHierarchy == false){
            CanvasMenu.SetActive(true);
            speed = 0;
            JumpForce = 0;
 
        }else if(Input.GetKeyDown(KeyCode.Escape) && CanvasMenu.activeInHierarchy){
            CanvasMenu.SetActive(false);
            speed = 7.5f;
            JumpForce = 1400;
        }
        }
        private void OnCollisionExit(Collision other) {
            if(other.gameObject.CompareTag("ground")){
                IsGrounded = false;
            }if(other.gameObject.CompareTag("ground") && transform.rotation.eulerAngles.z == 0){
                ParticleSystemOne.SetActive(false);
            }else if(other.gameObject.CompareTag("ground") && transform.rotation.eulerAngles.z == 180){
            ParticleSystemTwo.SetActive(false);
        }
        }private void OnCollisionStay(Collision other) {
            if(other.gameObject.CompareTag("ground")){
                IsGrounded = true;
            }
        }private void OnCollisionEnter(Collision other){
            if(other.gameObject.CompareTag("ground") && transform.rotation.eulerAngles.z == 0){
            ParticleSystemOne.SetActive(true);
        }else if(other.gameObject.CompareTag("ground") && transform.rotation.eulerAngles.z == 180){
            ParticleSystemTwo.SetActive(true);
        }if(other.gameObject.CompareTag("spike")){
            gameObject.SetActive(false);
            Canvasress.SetActive(true);
            CanvasMenu.SetActive(false);
        }if(other.gameObject.CompareTag("win")){
            CanvasWin.SetActive(true);
            gameObject.SetActive(false);
        
        }
        }
        void Start()
        {
            JumpForce = 2400;
            CanvasStart.SetActive(true);
        }public void Jump(){
            if(Input.GetMouseButtonDown(0) && IsGrounded == true){  
           player.AddForce(new Vector2(player.velocity.x,JumpForce));
         }
        }public void Off(){
            gameObject.SetActive(false);
        }
}