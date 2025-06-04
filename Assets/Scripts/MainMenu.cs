using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Loads the main game scene
    public void PlayGame()
    {
     SceneManager.LoadScene("breh");
    }

    // Quits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}