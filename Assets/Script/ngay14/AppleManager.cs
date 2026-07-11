using UnityEngine;

public class AppleManager : MonoBehaviour
{
    private int _appleCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
       public void AddApple(int amount)
    {
        _appleCount += amount;
        Debug.Log("Apple Count: " + _appleCount);
    }
}


