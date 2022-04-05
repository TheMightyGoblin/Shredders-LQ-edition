using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]float delayTime = 0.5f;
    [SerializeField]ParticleSystem crashEffect;
    bool crashed = false;
    void OnTriggerEnter2D(Collider2D other) 
    {   
        if(other.tag == "Ground" && !crashed)
        {
            crashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delayTime);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
