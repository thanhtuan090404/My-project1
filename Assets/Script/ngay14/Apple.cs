using UnityEngine;

public class Apple : MonoBehaviour
{
    private AppleManager appleManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("có va chạm");
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AddScore(1);

            // Add apple collection logic here
            Debug.Log("Apple collected!");
            Destroy(gameObject); // Destroy the apple object after collection
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
