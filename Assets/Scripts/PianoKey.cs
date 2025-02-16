using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoKey : MonoBehaviour
{
    Image image;
    Color originalColour;
    float pressTimer = 0;
    public AudioClip note;
    public AudioSource audio;

    void Start()
    {
        image = GetComponent<Image>();
        originalColour = image.color;
    }

    void Update()
    {
        if (image.color != originalColour) 
        {
            pressTimer += Time.deltaTime;
            if (pressTimer > 0.5)
            {
                image.color = originalColour;
            }
        }
    }

    public void PlayKey()
    {
        image.color = Color.red;
        pressTimer = 0;
        audio.PlayOneShot(note);
    }
}
