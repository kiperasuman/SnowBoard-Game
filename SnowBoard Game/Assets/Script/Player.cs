using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    Rigidbody2D rigidbody;
    SurfaceEffector2D surfaceEffector;

    [SerializeField] float SpeedUp = 30;
    [SerializeField] float speedStabil = 10;

    bool canMove = true;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();

    }
    void Update()
    {
        if (canMove == true)
        {
            RotateGamer();
            ProcessToSpeed();
        }

    }
    public void DisableControls()
    {
        canMove = false;
    }

    void RotateGamer()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-torqueAmount);
        }

    }
    void ProcessToSpeed()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = SpeedUp;
        }
        else
        {
            surfaceEffector.speed = speedStabil;
        }
    }


}
