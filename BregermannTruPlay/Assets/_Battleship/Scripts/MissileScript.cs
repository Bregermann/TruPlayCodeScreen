using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    private BSGameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("BSGameManager").GetComponent<BSGameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameManager.CheckHit(collision.gameObject);
        Destroy(gameObject);
    }
}
