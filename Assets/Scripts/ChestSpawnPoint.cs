using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawnPoint : MonoBehaviour
{
    public GameObject prefabToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Used to spawn a new game object
    public GameObject SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            // Instantiate the prefab at the location of the current SpawnPoint object
            // Quaternion is a data structure used to represent rotations; identity = no rotation
            return Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }

        return null;
    }
}
