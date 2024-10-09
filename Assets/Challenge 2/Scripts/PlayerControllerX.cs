using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float minSpawnDogTime = 1f;
    private float lastSpawnDogTime = 0f;

    // Update is called once per frame
    void Update()
    {
        lastSpawnDogTime += Time.deltaTime;
        // On spacebar press, send dog
        if (lastSpawnDogTime > minSpawnDogTime)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastSpawnDogTime = 0;
            Instantiate(dogPrefab, transform.position,
            dogPrefab.transform.rotation);
        }
    }
}
