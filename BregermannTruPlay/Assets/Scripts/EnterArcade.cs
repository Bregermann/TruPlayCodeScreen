using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterArcade : MonoBehaviour
{
    public Text playText;
    public int whichGame;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        playText.text = "Press F to Play!";
        if (Input.GetKeyDown(KeyCode.F))
        {
            canvas.SetActive(false);
            SceneManager.LoadScene(whichGame);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playText.text = "";

    }
}
