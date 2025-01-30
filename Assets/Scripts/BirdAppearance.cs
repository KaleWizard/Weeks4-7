using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAppearance : MonoBehaviour
{
    public SpriteRenderer sr;
    public AudioSource audioSource;

    void Update()
    {
        sr.enabled = audioSource.isPlaying;
    }
}
