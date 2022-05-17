using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {

        Time.timeScale = 0f;
        pause.SetActive(true);
        gameIsPaused = true;
    }
    void ResumeGame()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
        gameIsPaused = false;
    }
}
