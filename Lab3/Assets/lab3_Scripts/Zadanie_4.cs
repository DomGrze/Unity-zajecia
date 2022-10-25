using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_4 : MonoBehaviour
{
    public float speed = 3.0f;
    public Rigidbody rb;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + velocity);
    }
}
