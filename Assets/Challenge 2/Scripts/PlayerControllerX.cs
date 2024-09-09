using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, start coroutine to send dog after 2 seconds
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpawnDogAfterDelay(1.0f));
        }
    }

    // Coroutine to spawn dog after a delay
    IEnumerator SpawnDogAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
