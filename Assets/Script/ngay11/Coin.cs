using UnityEngine;

public class Coin : MonoBehaviour
{
    private ScoreManager _scoreManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _scoreManager.AddScore(1);
            // Add coin collection logic here
            Debug.Log("Coin collected!");
            Destroy(gameObject); // Destroy the coin object after collection
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
