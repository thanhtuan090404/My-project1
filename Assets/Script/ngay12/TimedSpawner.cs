using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private float _timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
       // InvokeRepeating("SpawnCoin", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 2f)
        {
            SpawnCoin();
            _timer = 0f;
        }
    }
    void SpawnCoin()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 Pos = new Vector3(x, 2f, z);
        Instantiate(coinPrefab, Pos, Quaternion.identity);
        Debug.Log("Coin spawned at: " + Pos);
    }
}
