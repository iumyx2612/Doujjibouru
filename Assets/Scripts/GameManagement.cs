using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public bool endGame = false;
    public GameObject levelComplete;

    public void EndGame()
    {
        if (endGame == false)
        {
            endGame = true;

            Restart();
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        levelComplete.SetActive(true);
        Invoke("GoNext", 1);
    }  
    public void GoNext()
    {
        SceneManager.LoadScene(1);
    }
}
