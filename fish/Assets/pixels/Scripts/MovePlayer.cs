using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"), moveY = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + new Vector2(moveX, moveY) * speed * Time.deltaTime);

    }
}
