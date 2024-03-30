using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public AudioSource Gamemusic;
    public Scrollbar volumeScroll;
    public GameObject[] StartMusic;
    private void Start() {
        // mYmusic.volume = volumeScroll.value;
        Gamemusic = GetComponent<AudioSource>();
    }private void Update() {
       Gamemusic.volume = volumeScroll.value;
       StartMusic = GameObject.FindGameObjectsWithTag("startMusic");
       foreach(GameObject DelStartMusic in StartMusic){
        Destroy(DelStartMusic);
       }

    }
}
