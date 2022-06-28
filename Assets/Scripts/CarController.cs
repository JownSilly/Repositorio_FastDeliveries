using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float rotateSpeed = 90;
    public float moveSpeed = -3;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.angularVelocity = Input.GetAxis("Horizontal") * rotateSpeed;
        rb.velocity = transform.right * Input.GetAxis("Vertical") * moveSpeed;
    }
}
