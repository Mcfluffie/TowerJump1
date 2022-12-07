using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRun : MonoBehaviour
{
    // The speed at which the platform moves down
    public float platformSpeed = 2.0f;

    // The speed at which the spawned objects move down
    public float objectSpeed = 5.0f;
    public float spawnHight = 50f;

    // The minimum and maximum time between object spawns
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 3.0f;

    // A reference to the object prefab that will be spawned
    public GameObject objectPrefab;

    // The spawn timer, which counts down to the next spawn
    private float spawnTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the platform down by the specified speed
        transform.position += Vector3.down * platformSpeed * Time.deltaTime;

        // If the platform has moved off the bottom of the screen,
        // move it back to the top of the screen
        if (transform.position.y < -10.0f)
        {
            transform.position = new Vector3(transform.position.x, 10.0f, transform.position.z);
        }

        // Update the spawn timer
        spawnTimer -= Time.deltaTime;

        // If the spawn timer is less than or equal to 0, it's time to spawn an object
        if (spawnTimer <= 0.0f)
        {
            // Reset the spawn timer to a random value between the minimum and maximum spawn times
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);

            // Spawn the object at the top of the screen
            GameObject spawnedObject = Instantiate(objectPrefab, new Vector3(transform.position.x, spawnHight, 0.0f), Quaternion.identity);

            // Set the object's speed
            spawnedObject.GetComponent<ObjectMovement>().speed = objectSpeed;
        }
    }
}
