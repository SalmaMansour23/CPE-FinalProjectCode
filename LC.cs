// Importing necessary Unity engine libraries
using UnityEngine;
using UnityEngine.SceneManagement;

// Defining a class named "LC" 
public class LC : MonoBehaviour
{
    public GameObject RedNoise;
    public GameObject WhiteNoise;
    public GameObject GuidedMeditationNoise;
    public GameObject FireCracklingAndRainNoise;
    public GameObject BeachWavesNoise;

    // Method to load the "Beach" scene
    public void LoadBeachScene()
    {
        Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Beach"
        SceneManager.LoadScene("Beach");
    }

    // Method to load the "Starry Night Sky" scene
    public void LoadStarryNightSkyScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Starry Night Sky"
        SceneManager.LoadScene("Starry Night Sky");
    }

    // Method to load the "Mountains Scene" scene
    public void LoadMountainsScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Mountains Scene"
        SceneManager.LoadScene("Mountains Scene");
    }

    // Method to load the "Dusk" scene
    public void LoadDuskScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Dusk"
        SceneManager.LoadScene("Dusk");
    }

    // Method to load the "Dawn" scene
    public void LoadDawnScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Dawn"
        SceneManager.LoadScene("Dawn");
    }

    // Method to load the "MainMainMenu" scene
    public void LoadMainMainMenuScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "MainMainMenu"
        SceneManager.LoadScene("MainMainMenu");
    }

    // Method to load the "RelaxingEnvironmentsMenu" scene
    public void LoadRelaxingEnvironmentsMenuScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "RelaxingEnvironmentsMenu"
        SceneManager.LoadScene("RelaxingEnvironmentsMenu");
    }

    // Method to load the "ExposureTherapyMenu" scene
    public void LoadExposureTherapyMenuScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "ExposureTherapyMenu"
        SceneManager.LoadScene("ExposureTherapyMenu");
    }

    // Method to load the "SpiderRoom" scene
    public void LoadSpiderRoomScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "SpiderRoom"
        SceneManager.LoadScene("SpiderRoom");
    }

    // Method to load the "Acrophobia" scene
    public void LoadAcrophobiaScene()
    {
         Debug.Log("SWITCHING SCENE");
        // Using SceneManager to load the scene named "Acrophobia"
        SceneManager.LoadScene("Acrophobia");
    }

    //Method to play white noise
    public void PlayWhiteNoise()
    {
         Debug.Log("Play White NOISE");
        WhiteNoise.SetActive(true);
    }

    //Method to play red noise
    public void PlayRedNoise()
    {
        Debug.Log("Play Red NOISE");
        RedNoise.SetActive(true);
    }

    //Method to play guided meditation noise
    public void PlayMeditationNoise()
    {
        Debug.Log("Play Meditation NOISE");
        GuidedMeditationNoise.SetActive(true);
    }
    
    //Method to play fire crackling and rain noise
    public void PlayRainNoise()
    {
        Debug.Log("Play Rain NOISE");
        FireCracklingAndRainNoise.SetActive(true);
    }

    //Method to play gentle beach waves noise
    public void PlayBeachNoise()
    {
        Debug.Log("Play Beach NOISE");
        BeachWavesNoise.SetActive(true);
    }
}
