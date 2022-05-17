using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioSource voSource;
    public AudioClip vo;
    public GameObject trig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayIt();
        trig.GetComponent<BoxCollider>().enabled = false;
    }
    void PlayIt()
    {
        voSource.clip = vo;
        voSource.Play();
    }
}
