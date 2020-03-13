using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 StrafeForce;
    public Vector3 JumpForce;
    public bool IsGrounded;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            //rb.AddForce(StrafeForce);
            transform.position = transform.position + StrafeForce;
        }
        if (Input.GetKeyDown("a"))
        {
            //rb.AddForce(-StrafeForce);
            transform.position = transform.position - StrafeForce;
        }
        if (Input.GetKeyDown("w"))
        {
            if(IsGrounded == true)
            {
                rb.AddForce(JumpForce);
                IsGrounded = false;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
            IsGrounded = true;
    }
}
