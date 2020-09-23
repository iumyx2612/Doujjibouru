using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesManager : MonoBehaviour
{

    public GameObject[] linesPrefabs;
    public Transform ball;
    int line_length = 100;
    int line_spawnZ = 0;
    int line_amount = 6;


    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0;i<3;i++)
        {
            SpawnLines();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.z > line_spawnZ - line_amount * line_length)
        {
            SpawnLines();
        }
    }


    public void SpawnLines(int prefabIndex = -1)
    {
        GameObject gameObj;
        gameObj = Instantiate(linesPrefabs[0]) as GameObject;
        gameObj.transform.SetParent(transform);
        gameObj.transform.position = Vector3.forward * line_spawnZ;
        line_spawnZ += line_length;
    }
}
