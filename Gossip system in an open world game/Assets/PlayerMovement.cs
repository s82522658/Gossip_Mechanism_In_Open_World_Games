using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float moveSpeed = 5f;
    [SerializeField]float jumpSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal"); // Return -1(left) or 1(right)
        float vInput = Input.GetAxis("Vertical");// Return -1(down) or 1(up)
        rb.velocity = new Vector3(hInput*moveSpeed, rb.velocity.y, vInput*moveSpeed);

        if (Input.GetButtonDown("Jump")){ //Bind to Input manager
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y+jumpSpeed, rb.velocity.z);
        
        }
    }
}
