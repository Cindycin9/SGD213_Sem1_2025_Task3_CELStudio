using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;
// Manages game-wide logic: game over screen, coin count, scene transitions
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameManagerScript Instance;

    private int coinCount = 0;
    [SerializeField]
    private TextMeshProUGUI coinText;
    
    // Called when the object is first initialized
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    // Reloads the current scene
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount;
        }
    }
}
