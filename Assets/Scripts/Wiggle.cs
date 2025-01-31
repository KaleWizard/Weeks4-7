using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    public GameObject calmWiggler;
    public GameObject angryWiggler;

    public AnimationCurve wiggleCurve;

    bool isWiggling = false;

    float animationTimer = 0f;

    void Update()
    {
        Vector2 posDist = Input.mousePosition - transform.position;
        bool xOverlap = Mathf.Abs(posDist.x) < 50;
        bool yOverlap = Mathf.Abs(posDist.y) < 50;
        if (xOverlap && yOverlap && !isWiggling)
        {
            isWiggling = true;
            animationTimer = 0f;
            calmWiggler.SetActive(false);
            angryWiggler.SetActive(true);
        }
        if ((!xOverlap || !yOverlap) && isWiggling)
        {
            isWiggling = false;
            calmWiggler.SetActive(true);
            angryWiggler.SetActive(false);
        }

        if (isWiggling)
        {
            animationTimer += Time.deltaTime;
            transform.localScale = Vector3.one * wiggleCurve.Evaluate(animationTimer);
        }
    }
}
