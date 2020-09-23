using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontalMov;
    public float forWardMov;
    public float verticalMov;
    public float maxSpeed;    

    void FixedUpdate()
    {
        rb.AddForce(0, 0, (forWardMov) * Time.deltaTime, ForceMode.Acceleration);
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(horizontalMov) * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce((horizontalMov) * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }       
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -(forWardMov * 2) * Time.deltaTime, ForceMode.Acceleration);
        }
        if (rb.velocity.magnitude < maxSpeed / 2)
        {
            horizontalMov = 1500;
        }
        else  if ((rb.velocity.magnitude >= maxSpeed/2) && (rb.velocity.magnitude <maxSpeed))
        {
            horizontalMov = 2000;
        }        
        if (rb.velocity.magnitude>maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        if (rb.velocity.magnitude == maxSpeed)
        {
            horizontalMov = 3000;
        }
        if (rb.position.y<=-3)
        {
            FindObjectOfType<GameManagement>().EndGame();
        }

    }
}
