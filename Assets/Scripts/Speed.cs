using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Text speed;
    public BallMovement player;
    void Update()
    {
        speed.text = "Speed: " + player.rb.velocity.z.ToString("0");
    }
}
