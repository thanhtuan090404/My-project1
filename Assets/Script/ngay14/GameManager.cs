using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI messageText;   // "You Win!" / "Game Over"
    [SerializeField] private int coinsToWin = 8;
    [SerializeField] private float timeLimit = 60f;
    [SerializeField] private GameObject restartButton;

    private int _score;
    private float _timeRemaining;
    private bool _gameEnded;

    void Start()
    {
        _timeRemaining = timeLimit;
        messageText.text = "";           // ẩn thông báo lúc đầu
        restartButton.SetActive(false);

        UpdateScoreUI();
    }

    void Update()
    {
        if (_gameEnded) return;

        _timeRemaining -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.CeilToInt(_timeRemaining);

        if (_timeRemaining <= 0)
        {
            EndGame(false);   // hết giờ → thua
        }
    }

    public void AddScore(int amount)
    {
        if (_gameEnded) return;

        _score += amount;
        UpdateScoreUI();

        if (_score >= coinsToWin)
        {
            EndGame(true);    // đủ coin → thắng
        }
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Coins: " + _score + " / " + coinsToWin;
    }

    private void EndGame(bool won)
    {
        _gameEnded = true;
        messageText.text = won ? "You Win!" : "Game Over";
        restartButton.SetActive(true);

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}