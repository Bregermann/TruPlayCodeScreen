using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineBroken : MonoBehaviour
{
    public Text playText;

    private void OnTriggerStay(Collider other)
    {
        playText.text = "The Machine is Broken?!";

    }
    private void OnTriggerExit(Collider other)
    {
        playText.text = "";

    }
}
