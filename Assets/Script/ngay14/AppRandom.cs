using UnityEngine;

public class AppRandom : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnApple", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnApple()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 Pos = new Vector3(x, 1f, z);
        Instantiate(applePrefab, Pos, Quaternion.identity);
        Debug.Log("Apple spawned at: " + Pos);
    }
}
