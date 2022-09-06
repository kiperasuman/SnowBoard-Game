using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Zemin")
        {
            particleSystem.Play();
        }
    }
     void OnCollisionExit2D(Collision2D collision)
     {
        if(collision.gameObject.tag == "Zemin"){
            particleSystem.Stop();
        }
     }
}
