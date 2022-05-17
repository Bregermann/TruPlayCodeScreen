using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool battleshipWin;
    public bool breakoutWin;
    public bool tictactoeWin;

    public GameObject player;
    public GameObject[] playerSpawn;
    public int whichPlayerSpawn;

    public GameObject pauseMenu;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.transform.position = playerSpawn[0].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.transform.position = playerSpawn[1].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.transform.position = playerSpawn[2].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player.transform.position = playerSpawn[3].transform.position;
        }
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
    }
}
