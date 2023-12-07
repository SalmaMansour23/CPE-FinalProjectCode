using UnityEngine;

public class AcrophobiaHandler : MonoBehaviour
{
    // Public variables to adjust in the inspector
    public GameObject player; // Assign your player object here
    public GameObject sea; // Assign your sea object here
    public GameObject tower; // Assign your tower object here
    public GameObject playerSpawner; // Assign your player spawner object here

    public float seaMoveDownUnits = 5f; // How much the sea moves down each time
    public float towerShrinkUnits = 1f; // How much the tower shrinks in X and Z axis

    // Audio variables
    public AudioSource windAudioSource;
    public float maxVolume = 1.0f; // Maximum volume for the wind sound
    public float volumeIncrement = 0.1f; // Volume increment on collision

    void Start()
    {
        Debug.Log("Script Starting");
        // Ensure the wind sound starts with zero volume
        windAudioSource.volume = 0.0f;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter Before");
        // Check if the player collided with the sea
        if (collision.gameObject == player)
        {
            Debug.Log("In");
            // Respawn the player at the player spawner's location
            player.transform.position = playerSpawner.transform.position;

            // Reset player's rotation to be upright
            player.transform.rotation = Quaternion.identity;

            // Move the sea downwards
            sea.transform.Translate(0, -seaMoveDownUnits, 0);

            // Shrink the tower in X and Z axes
            Vector3 towerScale = tower.transform.localScale;
            towerScale.x -= towerShrinkUnits;
            towerScale.z -= towerShrinkUnits;
            tower.transform.localScale = towerScale;

            // Increase the wind sound volume
            if (windAudioSource.volume < maxVolume)
            {
                windAudioSource.volume += volumeIncrement;
            }
        }
    }
}
