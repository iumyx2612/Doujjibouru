using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject freezeMenu;
    public static bool gameIsFreeze = false;

    public void OnTriggerEnter()
    {
       Active();
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsFreeze)
            {
                Deactive();
            }
            else
            {
                Active();
            }
        }
    }

    public void Active()
    {
        Debug.Log("Active");
        freezeMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsFreeze = true;
    }

    public void Deactive()
    {
        Debug.Log("Deact");
        freezeMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsFreeze = false;
    }    

}
