using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMover : MonoBehaviour
{
   [SerializeField] private float speedMove = 5f;
   [SerializeField] private float jumpForce = 5f;

    private float _h, _v;
    private Rigidbody _rb;
    private bool _jumpRequest;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * speedMove);
        //}
        //else if (Input.GetKey(KeyCode.S))
        // {
        //    transform.Translate(Vector3.back * Time.deltaTime * speedMove);
        // }
        //else if(Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime * speedMove);
        //}
        //else if (Input.GetKey(KeyCode.D)) 
        //{
        //    transform.Translate(Vector3.right * Time.deltaTime * speedMove);
        //}

        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpRequest = true; // ghi nhân yêu cầu nhảy xử lý ở fixedUpdate
        }

    }
    void FixedUpdate()
    {
        Vector3 move = new Vector3(_h, 0, _v);
        _rb.MovePosition(_rb.position + move * speedMove * Time.fixedDeltaTime);

        if (_jumpRequest)
        {
            _rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
            _jumpRequest = false;
        }
    }
    
}
