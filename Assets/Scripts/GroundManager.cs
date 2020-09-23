using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject[] GroundPrefabs;
    public Transform ball;
    private float gnd_spawnZ = 0f;
    private float gnd_length = 100f;
    private int gnd_amount = 6;
    private float safeZone = 150f;

    private List<GameObject> activeGrounds;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0;i<=3;i++)
        {
            SpawnGround();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.position.z-safeZone>gnd_spawnZ-gnd_amount*gnd_length)
        {
            SpawnGround();
            DeleteGround();
        }
    }

    public void SpawnGround(int prefabIndex=-1)
    {
        GameObject gameObj;
        gameObj = Instantiate(GroundPrefabs[0]) as GameObject;
        gameObj.transform.SetParent(transform);
        gameObj.transform.position = Vector3.forward * gnd_spawnZ;
        gnd_spawnZ += gnd_length;
        activeGrounds.Add(gameObj);
    }
       
    public void DeleteGround()
    {
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }
}
