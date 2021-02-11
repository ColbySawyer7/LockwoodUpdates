using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{
    // Reference to the spawn points
    public SpawnPoint chestSpawnPointTR;
    public SpawnPoint chestSpawnPointT;
    public SpawnPoint chestSpawnPointTL;
    public SpawnPoint chestSpawnPointBR;
    public SpawnPoint chestSpawnPointM;
    public SpawnPoint chestSpawnPoint;

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
        SetupScene();        
    }

    public void SetupScene()
    {   
        int random = Random.Range(0,5);
        SpawnChest(random);
    }

    // Create a new player object if one does not already exist
    public void SpawnChest(int random)
    {
        if(random == 5){
            if (chestSpawnPointT != null){
                GameObject chest = chestSpawnPointT.SpawnObject();
            }
        }else if(random == 4){
            if (chestSpawnPointTL != null){
                GameObject chest = chestSpawnPointTL.SpawnObject();
            }
        }else if(random == 3){
            if (chestSpawnPointTR != null){
                GameObject chest = chestSpawnPointTR.SpawnObject();
            }
        }else if(random == 2){
            if (chestSpawnPointBR != null){
                GameObject chest = chestSpawnPointBR.SpawnObject();
            }

        }else if(random == 1){
            if (chestSpawnPointM != null){
                GameObject chest = chestSpawnPointM.SpawnObject();
            }
        }else{
            if (chestSpawnPoint != null){
                GameObject chest = chestSpawnPoint.SpawnObject();
            }
        }
    }
}
