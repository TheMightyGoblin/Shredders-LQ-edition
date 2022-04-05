using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {   
        if(other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
