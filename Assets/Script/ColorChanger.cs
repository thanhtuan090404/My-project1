using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
