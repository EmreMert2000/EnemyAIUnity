using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime*speed;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;
         Vector3 movesystem = new Vector3(horizontalInput, 0, verticalInput);
        //rb.AddForce(movesystem);
        transform.position += movesystem * speed;
    }
}
