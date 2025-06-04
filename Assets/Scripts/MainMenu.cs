using UnityEngine;
using UnityEngine.SceneManagement;

// Handles main menu button functionality
public class MainMenu : MonoBehaviour
{
    // Loads the main game scene
    // Called when the player presses the "Play" button
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