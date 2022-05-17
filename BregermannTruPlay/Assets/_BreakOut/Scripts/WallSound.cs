using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSound : MonoBehaviour
{
    public AudioSource wallSource;
    public AudioClip[] wallClips;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        wallSource.clip = wallClips[Random.Range(0, wallClips.Length)];
        wallSource.Play();
    }

    }
