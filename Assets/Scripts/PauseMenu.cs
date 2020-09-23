using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false;
    public GameObject PauseMenuUI;
    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(Pause);
    }
    // Update is called once per frame
    void Update()
    {        
        //if(gameIsPause==true)
        //{
        //    Resume();
        //}
        //else
        //{
        //    Pause();
        //}
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        gameIsPause = false;
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        gameIsPause = true;
        Time.timeScale = 0f;
    }
    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
