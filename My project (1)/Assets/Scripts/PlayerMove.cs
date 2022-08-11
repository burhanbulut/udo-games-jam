using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    public Rigidbody rb;
    public GameObject zemin;
    public bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        zemin = GameObject.FindWithTag("Floor");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
       if (Input.GetKey(KeyCode.Space) && onGround)
        {
            rb.AddForce((Vector3.up * jumpForce) , ForceMode.Force);
            onGround = false;
        }
        
    }


    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            onGround = true;
            
        }
    }


}
