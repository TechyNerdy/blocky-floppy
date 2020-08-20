using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;        //RB is like "as" in Python

    public float FowardForce = 500f; //This is how to create a varrible in C#              //Good habit of adding "F" at the end of every "float" vaule
    public float SidewayForce = 500f;
    public float BackwardForce = 500f;
    public float UpwardsForce = 500f;

    void FixedUpdate()      //WHen dealing with Phyicisis in Unity, remember to use "FixedUpdate" it works better and smoother.
    {
        //rb.AddForce(0, 0, FowardForce *Time.deltaTime);        // Time.deltaTime so that it woundn't matter with the FPS

        if( Input.GetKey("d") )
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0 , 0 , ForceMode.VelocityChange);
        }

        //if( Input.GetKey("w") )
        //{
            //rb.AddForce(0, 0, FowardForce * Time.deltaTime , ForceMode.VelocityChange);
        //}

        if( Input.GetKey("a") )
        {
            rb.AddForce( -SidewayForce * Time.deltaTime, 0 , 0 , ForceMode.VelocityChange);
        }

        if( Input.GetKey("s") )
        {
            rb.AddForce(0, 0, -FowardForce * Time.deltaTime , ForceMode.VelocityChange);
        }

       rb.AddForce(0, 0 , FowardForce * Time.deltaTime , ForceMode.VelocityChange);

    }
    
    void Update() //when i use "Void Update" for jumping it works smoother.
    {
        if( Input.GetButtonDown("Jump") ) 
       {
           rb.AddForce(new Vector3(0 , 5 , 0) , ForceMode.Impulse); //cannot use * Time.deltaTime for some reason
       }
    }
}       