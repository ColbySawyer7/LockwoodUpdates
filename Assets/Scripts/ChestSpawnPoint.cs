using UnityEngine;

public class ChestSpawnPoint : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public float repeatInterval;
    // Start is called before the first frame update
    void Start()
    {
        // If the object should be repeatedly spawned
        if (repeatInterval > 0)
        {
            // Call the "SpawnObject" method repeatedly
            // Wait 0.0 time before calling the first time
            // repeatInterval is how often to call the method
            InvokeRepeating("SpawnObject", 0.0f, repeatInterval);
        }
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
