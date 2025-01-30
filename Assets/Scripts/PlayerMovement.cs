
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
        transform.position += velocity * speed * Time.deltaTime;
    }
}
