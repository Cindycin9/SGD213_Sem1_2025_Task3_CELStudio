using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Loads the main game scene
    public void PlayGame()
    {
     SceneManager.LoadScene("breh");
        Debug.Log("breh Loaded!");
    }

    // Quits the game
    public void QuitGame()
    {
        Application.Quit();
            Debug.Log("Quit Game!");
    }
}