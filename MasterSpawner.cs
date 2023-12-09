using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MasterSpawner : MonoBehaviour
{
    // Declare the mini spawners and spider prefabs as public Game Objects
    public GameObject[] miniSpawners = new GameObject[4];
    public GameObject[] spiderPrefabs = new GameObject[4];

    // Declare the public parameters editable in the Unity Editor
    public int MaxSpiderCount;
    public float SpiderSpeed;
    public float SpiderSizeMultiplier = 0.1f;
    public GameObject Player;

    // Private variables to keep track of the number of spiders and their shared properties
    private int currentSpiderCount = 0;
    private bool isSpawning = false;

    void Update()
    {
        // Check for the 'A' oculus input to start or stop the spawning process
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            isSpawning = !isSpawning; // Toggle the spawning state
        }

        // Spawn spiders if the spawning state is true and the max count hasn't been reached
        if (isSpawning && currentSpiderCount < MaxSpiderCount)
        {
            SpawnSpiders();
        }

        // Check for the 'B' oculus input to increase the size multiplier
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            SpiderSizeMultiplier += 0.1f;
            
            //Update the size of all existing spiders
            UpdateAllSpidersSize();
        }

        // Check for the 'X' oculus input to increase the speed
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            SpiderSpeed += 0.1f;
            
            // Update the speed of all existing spiders
            UpdateAllSpidersSpeed();
        }
    }

    void SpawnSpiders()
    {
        // Iterate through all mini spawners and spawn each type of spider
        for (int i = 0; i < miniSpawners.Length; i++)
        {
            // Instantiate a spider prefab at the mini spawner's position
            GameObject spider = Instantiate(spiderPrefabs[i], miniSpawners[i].transform.position, Quaternion.identity);
            spider.transform.localScale *= SpiderSizeMultiplier; // Scale the spider size
            Rigidbody spiderRigidbody = spider.GetComponent<Rigidbody>(); //Access the rigid body of the spider
            spiderRigidbody.useGravity = true; // Let the spider fall to the ground
            currentSpiderCount++; // Increment the spider count
            SpiderBehavior spiderBehavior = spider.AddComponent<SpiderBehavior>(); // Add the SpiderBehavior script
            spiderBehavior.Initialize(Player, SpiderSpeed); // Initialize the spider behavior
        }
    }

    void UpdateAllSpidersSize()
    {
        // Find all spiders in the scene and update their size
        SpiderBehavior[] allSpiders = FindObjectsOfType<SpiderBehavior>();
        foreach (SpiderBehavior spider in allSpiders)
        {
            spider.transform.localScale *= (1/SpiderSizeMultiplier); // Scale the spider size
        }
    }

    void UpdateAllSpidersSpeed()
    {
        // Find all spiders in the scene and update their speed
        SpiderBehavior[] allSpiders = FindObjectsOfType<SpiderBehavior>();
        foreach (SpiderBehavior spider in allSpiders)
        {
            spider.UpdateSpeed(SpiderSpeed); //Increase spider speed
        }
    }
}

// Separate class for the spider behavior
public class SpiderBehavior : MonoBehaviour
{
    private GameObject player;
    private float speed;

    //Initialization
    public void Initialize(GameObject targetPlayer, float spiderSpeed)
    {
        player = targetPlayer;
        speed = spiderSpeed;
    }

    //Allows updating the speed
    public void UpdateSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        // Always look towards the player object
        transform.LookAt(player.transform);
        // Move towards the player object at the declared speed
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
