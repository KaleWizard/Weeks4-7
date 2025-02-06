using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWhilePlaying : MonoBehaviour
{
    float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = (rotation + Time.deltaTime * 30) % 360;
        transform.eulerAngles = Vector3.back * rotation;
    }
}
