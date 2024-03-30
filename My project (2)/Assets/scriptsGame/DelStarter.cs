using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelStarter : MonoBehaviour
{
    private void Start() {
        StartCoroutine(Wait());
    }IEnumerator Wait(){
        yield return new WaitForSeconds(1f);
            gameObject.SetActive(false);
        
    }
}
