using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderRotation : MonoBehaviour
{
    public Slider slider;

    float lastVal;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        lastVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = Vector3.back * slider.value;

        if (slider.value != lastVal && !audio.isPlaying)
        {
            audio.Play();
        }

        lastVal = slider.value;
    }
}
