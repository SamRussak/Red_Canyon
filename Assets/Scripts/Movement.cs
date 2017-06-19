using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Transform t = null;
    public float Speed;
    private Rigidbody r = null;
    public float TurnSpeed;
    public float Health = 100;


    // get transform and rigidbody of Anti-Virus
    // add listeners to buttons
    //if a particular button is clicked, call the correct method
    void Start()
    {
        t = this.GetComponent<Transform>();
        r = this.GetComponent<Rigidbody>();
    }
    //move player forward
    //check players health, if dead eand game
    void Update()
    {
        Quaternion rotation = t.rotation;
        Vector3 dir = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            dir = t.forward * 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotation *= Quaternion.AngleAxis(TurnSpeed * Time.deltaTime * -1f, Vector3.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir = t.forward * -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotation *= Quaternion.AngleAxis(TurnSpeed * Time.deltaTime, Vector3.up);
        }
        t.rotation = rotation;
        t.position += dir * Time.deltaTime * Speed;

    }
    //lower health is bullet hits player
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Equals("Bullet(Clone)"))
    //    {
    //        Health -= 5;
    //    }
    //}


}


