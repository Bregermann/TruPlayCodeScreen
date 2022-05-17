using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject GM = GameObject.Find("GameManager");
        GameManager G = GM.GetComponent<GameManager>();
        G.relics++;
        Destroy(this.gameObject);
    }
}
