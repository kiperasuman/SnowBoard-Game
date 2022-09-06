using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem deadEffect;
    [SerializeField] float crashTime = 0.1f;
    [SerializeField] AudioClip audioClip;
    [SerializeField] Player player;
   
    bool hasCrashed = false;
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Zemin" && hasCrashed == false)
        {
            hasCrashed = true;
            deadEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(audioClip);
           
            // ya da bunu kullanabilirsin : 
           //  FindObjectOfType<Player>().DisableControls();
            player.DisableControls();
            
            Invoke("ReloadScene",crashTime);
        }
    }
   
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
