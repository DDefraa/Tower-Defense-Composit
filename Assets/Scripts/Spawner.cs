using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public Transform[] pathPoints;
    public float speed = 5f;
    public float spawnDelay = 3f;

    private void Start()
    {
        // Start spawning objects
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Spawn objects from the list
            foreach (GameObject obj in objectPrefabs)
            {
                GameObject newObj = Instantiate(obj, transform.position, Quaternion.identity);

                // Attach follow path script to the object
                newObj.AddComponent<FollowPath>().SetPathPoints(pathPoints, speed);
            }

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
