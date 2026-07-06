using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int amount)
    {
        _score += amount;
        Debug.Log("Score: " + _score);
    }
}
