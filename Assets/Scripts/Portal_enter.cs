using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_enter : MonoBehaviour
{
    public BallMovement ball;
    public void OnTriggerEnter()
    {
        ball.rb.AddForce(0, 0, 5000);
    }
}
