using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float t = 0;
    public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = slider.minValue + (t / (slider.maxValue - slider.minValue));


        if (Input.GetMouseButtonDown(0) || t >= slider.maxValue)
        {
            t = 0;
        }
        t += Time.deltaTime;
    }
}
