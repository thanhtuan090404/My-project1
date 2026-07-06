using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i =0; i < 10; i++)
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            Vector3 Pos = new Vector3(x, 2f, z);
            Instantiate(coinPrefab, Pos, Quaternion.identity);
            Debug.Log("Coin spawned at: " + Pos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
