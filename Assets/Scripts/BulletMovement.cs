using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Vector3 velocity;
    public ValueModifier gravity;

    public void SetVelocity(Vector3 direction, float speed)
    {
        velocity = direction * speed;
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        velocity.y -= gravity.value * Time.deltaTime;
    }
}
