using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    string defaultText;
    

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        Debug.Log("in Start");   
    }

    void Update()
    {
        Debug.Log("in Update");
    }

    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach(TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
            Debug.Log(item.name);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void IncrementScore()
    {
        int score = 0;
        score++;
        scoreText.text = score.ToString();
    }
}
