using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text gameNameText;
    public TMP_Text scoreText;
    public TMP_Text msgText;

    public float score;
    public bool startGame;

    void Start()
    {
        startGame = false;

        score = 0;

        scoreText.gameObject.SetActive(false);
        msgText.gameObject.SetActive(true);
        gameNameText.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !startGame)
        {
            StartGame();
        }

        if (startGame)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void StartGame()
    {
        startGame = true;
        score = 0;

        scoreText.gameObject.SetActive(true);
        gameNameText.gameObject.SetActive(false);
        msgText.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        startGame = false;

        msgText.gameObject.SetActive(true);
        msgText.text = "GAME OVER";

        Invoke("RestartGame", 5f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}