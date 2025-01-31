using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    public string text;

    public InformationContainer infoContiner;

    // Start is called before the first frame update
    void Start()
    {
        infoContiner.sprites.Add(gameObject);
    }

    public bool IsMouseOverlapping()
    {
        Vector2 posDist = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        bool xOverlap = Mathf.Abs(posDist.x) < 1;
        bool yOverlap = Mathf.Abs(posDist.y) < 1;
        return xOverlap && yOverlap;
    }
}
