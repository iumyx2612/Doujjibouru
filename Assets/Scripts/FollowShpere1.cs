using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShpere1 : MonoBehaviour
{
    public Transform sphere1;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = sphere1.position + offset;
    }
}
