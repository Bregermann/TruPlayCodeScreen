using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterArcade : MonoBehaviour
{
    public Text playText;
    public int whichGame;

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
        GameObject pt;
        pt = GameObject.Find("ActionText");
        playText = pt.GetComponent<Text>();
        playText.text = "Press F to Play!";
        if (Input.GetKeyDown(KeyCode.F))
        {

            playText.text = "";
            SceneManager.LoadScene(whichGame);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playText.text = "";

    }
}
