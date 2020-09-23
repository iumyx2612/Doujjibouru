using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel : MonoBehaviour
{
    public GameObject greet;

    public void OnTriggerEnter()
    {
        greet.SetActive(true);
        Time.timeScale = 0f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            greet.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
