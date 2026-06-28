using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer _renderer;   // cache ở đây
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderer = GetComponent<Renderer>();   // gọi GetComponent ĐÚNG 1 LẦN

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
