using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    public AudioSource Gamemusic;

    private void Start() {
        // mYmusic.volume = volumeScroll.value;
        Gamemusic = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
        
    }
}
