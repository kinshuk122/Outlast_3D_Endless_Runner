using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 1000f;
    public GameObject ground;
    Rigidbody rb;
    float _offset;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _offset = (transform.position.y - ground.transform.position.y) + 1;
    }

    void Update()
    {
        if (transform.position.y - ground.transform.position.y < _offset)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * jumpForce);
            }
        }   
    }
}
