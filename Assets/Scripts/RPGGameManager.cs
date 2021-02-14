using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{
    // Reference to the spawn points
    private ChestSpawnPoint[] chestSpawns = new ChestSpawnPoint[6];

    public TimerController TimeController;

    public GameObject PlayerController;
    
    public GameObject chestSpawnPrefab;

    //Test Variable
    //public int random;

    // A variable used to access the singleton object
    public static RPGGameManager sharedInstance = null;

    // Ensure only a single instance of the RPGGameManager exists
    // It's possible to get multiple instances if multiple copies of the RPGGameManager exists in the Hierarchy
    // or if multiple copes are programmatically instantiated
    public void Awake()
    {
        // if sharedInstance has been initialized, but not to the current instance, then destroy it
        if (sharedInstance != null && sharedInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            sharedInstance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        initializeSpawnPoints(); 
        SetupScene();
    }

    public void initializeSpawnPoints(){
        chestSpawns[0] = Instantiate(chestSpawnPrefab, new Vector3(6.5f,6.5f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
        chestSpawns[1] = Instantiate(chestSpawnPrefab, new Vector3(11.5f,5.0f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
        chestSpawns[2] = Instantiate(chestSpawnPrefab, new Vector3(1.5f,6.5f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
        chestSpawns[3] = Instantiate(chestSpawnPrefab, new Vector3(-9.0f,6.5f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
        chestSpawns[4] = Instantiate(chestSpawnPrefab, new Vector3(11.5f,-5.5f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
        chestSpawns[5] = Instantiate(chestSpawnPrefab, new Vector3(1.5f,1.5f,0.0f), Quaternion.identity).GetComponent<ChestSpawnPoint>();
    }

    public void SetupScene()
    {   
        int random = Random.Range(0,5);
        Debug.Log(random);
        GameObject chest = chestSpawns[random].SpawnObject();
    }

}
