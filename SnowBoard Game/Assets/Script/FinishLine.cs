using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
     [SerializeField] float crashTime = 0.1f;
    [SerializeField] ParticleSystem particlesystem;

     void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.tag == "Player")
        {
            particlesystem.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReLoadScene",crashTime);
        }
     }
    void ReLoadScene()
    {
        SceneManager.LoadScene(0);
    }
}

