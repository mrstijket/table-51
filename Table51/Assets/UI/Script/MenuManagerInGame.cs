using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGame : MonoBehaviour
{
    bool isPause=false;
    public GameObject inGameScreen, pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if(isPause==false)
            {
                isPause=true;
                Time.timeScale = 0;
                inGameScreen.SetActive(false);
                pauseScreen.SetActive(true);
            }
            else
            {
                isPause=false;
                ResumeButton();
            }
          
        }
        
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }


    

    public void HomeButton()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
    }


}