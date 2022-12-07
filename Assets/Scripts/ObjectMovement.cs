using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // The speed at which the object moves down
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the object down by the specified speed
        transform.position += Vector3.down * speed * Time.deltaTime;

        // If the object has moved off the bottom of the screen,
        // destroy it
        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }
    }
}
