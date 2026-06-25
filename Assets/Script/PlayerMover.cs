using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMover : MonoBehaviour
{
    private float speedMove = 5f;
    private float jumpForce = 135f;

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

       float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);

        transform.Translate(movement * Time.deltaTime * speedMove);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up*Time.deltaTime * jumpForce);
        }

    }
    
}
