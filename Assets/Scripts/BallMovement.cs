using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 10f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * speed * Time.deltaTime;
        }
    }

    
    void Update()
    {
        
    }
}
