using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obs_Col : MonoBehaviour
{
    public BallMovement BM;
    public Score score;

    void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag==("Obstacles"))
        {
            score.point -= 40;
            BM.rb.AddForce(0, 0, -1500f);
        }
    }
}
