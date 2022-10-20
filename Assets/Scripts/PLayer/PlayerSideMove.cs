using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSideMove : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    public float moveposL = 4f;
    public float moveposR = -4f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= moveposL)
        {
            dirRight = false;
        }

        if (transform.position.x <= moveposR)
        {
            dirRight = true;
        }
    }
}
