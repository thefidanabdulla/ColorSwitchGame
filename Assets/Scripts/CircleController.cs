using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, -speed);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
