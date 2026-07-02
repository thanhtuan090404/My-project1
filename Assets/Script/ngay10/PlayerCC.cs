using UnityEngine;

public class PlayerCC : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private float speed = 5f;
    private float _h , _v;
    private float _velocityY ;
    private float _garvity = -9.81f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = _controller.isGrounded;
        if (grounded && _velocityY < 0)
        {
            _velocityY = -2f;
        }
        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(_h, 0f, _v);
        _controller.Move(movement * speed * Time.deltaTime);

        _velocityY += _garvity * Time.deltaTime;

        _controller.Move(Vector3.up * _velocityY * Time.deltaTime);


    }
}
