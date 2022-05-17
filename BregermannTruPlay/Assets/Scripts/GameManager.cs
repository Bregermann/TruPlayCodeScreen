using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool battleshipWin;
    public bool breakoutWin;
    public bool tictactoeFinish;

    public GameObject player;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public int whichPlayerSpawn;

    public GameObject pauseMenu;

    public int relics;

    public GameObject relic;
    public GameObject tttRelicSpawn;
    public GameObject boRelicSpawn;
    public GameObject bsRelicSpawn;
    public int relicsToSpawn;

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
        if (tictactoeFinish == true && relicsToSpawn > 0)
        {
            tttRelicSpawn = GameObject.Find("TTTSpawn");
            Instantiate(relic, tttRelicSpawn.transform.position, tttRelicSpawn.transform.rotation);
            relicsToSpawn -= 1;
        }
        if (breakoutWin == true && relicsToSpawn > 0)
        {
            tttRelicSpawn = GameObject.Find("BOSpawn");
            Instantiate(relic, tttRelicSpawn.transform.position, tttRelicSpawn.transform.rotation);
            relicsToSpawn -= 1;
        }
        if (battleshipWin == true && relicsToSpawn > 0)
        {
            tttRelicSpawn = GameObject.Find("BSSpawn");
            Instantiate(relic, tttRelicSpawn.transform.position, tttRelicSpawn.transform.rotation);
            relicsToSpawn -= 1;
        }
        if (relics == 3)
        {
            SceneManager.LoadScene(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player = GameObject.Find("RigidBodyFPSController");
            spawn1 = GameObject.Find("InitialSpawn");
            player.transform.position = spawn1.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player = GameObject.Find("RigidBodyFPSController");
            spawn2 = GameObject.Find("TTTSpawn");
            player.transform.position = spawn2.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player = GameObject.Find("RigidBodyFPSController");
            spawn3 = GameObject.Find("BOSpawn");
            player.transform.position = spawn3.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player = GameObject.Find("RigidBodyFPSController");
            spawn4 = GameObject.Find("BSSpawn");
            player.transform.position = spawn4.transform.position;
        }
    }

}
