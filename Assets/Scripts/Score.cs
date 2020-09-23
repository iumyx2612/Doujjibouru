using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Transform player;
    public float point;
    float lastPos;
    float currentPos;
    void Update()
    {
        currentPos = player.transform.position.z;
        if(currentPos!=lastPos)
        {
            point += currentPos - lastPos;
        }
        lastPos = currentPos;
    }


    void LateUpdate()
    {           
        score.text = point.ToString("0");
    }
   

}
