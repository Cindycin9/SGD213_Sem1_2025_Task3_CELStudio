using UnityEngine;
using UnityEngine.SceneManagement;

// Manages pause menu functionality (pause, resume, quit, go to main menu)
public class PauseMenu : MonoBehaviour
{
    // Reference to the pause menu 
    public GameObject pauseMenu;

    public KeyCode pauseKey;
    public bool isPaused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }
    // Activates pause menu and freezes time

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    // Deactivates pause menu and resumes time
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    // Loads main menu scene and ensures time is unpaused
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    // Quits the game
    public void QuitGame()
    {
        Application.Quit();
    }
        
}
