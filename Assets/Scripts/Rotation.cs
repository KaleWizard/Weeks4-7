using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 5f;
    float totalRotation = 0f;

    public AudioSource audioSource;

    int timesToPlay = 0;
    int timesPlayed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z -= speed * Time.deltaTime;
        transform.eulerAngles = rot;
        
        totalRotation += speed * Time.deltaTime;
        if (totalRotation >= 30f)
        {
            totalRotation -= 30f;
            timesPlayed = 0;
            //timesToPlay = Mathf.RoundToInt(Mathf.RoundToInt(60 - rot.z) % 360 / 30 + 1);
            timesToPlay++;
            if (timesToPlay == 13) timesToPlay -= 12;

            Debug.Log(rot.z % 360);
            Debug.Log(timesToPlay);
        }
        if (timesToPlay > timesPlayed && !audioSource.isPlaying)
        {
            audioSource.Play();
            timesPlayed++;
        }
    }
}
