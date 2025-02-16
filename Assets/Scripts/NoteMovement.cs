using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    RectTransform rt;
    float lifeTimer = 0;
    Vector3 direction;
    Vector3 normal;
    public float speed = 200f;
    public float wobbleAmp = 300f;
    public float wobbleFrequency = 10f;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        float angle = Random.RandomRange(0f, Mathf.PI * 2);
        direction = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0);
        normal = new Vector3(-1 * direction.y, direction.x, 0);
        }

    void Update()
    {
        rt.position += direction * speed * Time.deltaTime;
        rt.position += normal * wobbleAmp * Mathf.Sin(lifeTimer * wobbleFrequency) * Time.deltaTime;
        lifeTimer += Time.deltaTime;
    }
}
