using UnityEngine;

public class PlayerRb : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private float h , v;
    private Rigidbody _rb;
    private bool _jumpRequest;

    

     void Awake()
    {
        // Get the Rigidbody component attached to the player
        _rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpRequest = true;
        }



    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(h, 0f, v);
        _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);

        if (_jumpRequest)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _jumpRequest = false;
        }
    }
}
