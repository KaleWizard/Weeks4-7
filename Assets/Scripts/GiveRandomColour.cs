using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveRandomColour : MonoBehaviour
{
    SpriteRenderer sr;

    public AudioClip buttonSound;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    public void RandomizeColour()
    {
        sr.color = Random.ColorHSV();
        audio.PlayOneShot(buttonSound);
    }
}
