using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public bool facingRight = true;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"), moveY = Input.GetAxis("Vertical");
        //rb.MovePosition(rb.position + new Vector2(moveX, moveY) * speed * Time.deltaTime);
        rb.velocity = new Vector2(moveX * speed, moveY * speed); //так вроде не трясется и все норм

        //дальше будет условие по разворону при хождение по x

        if (facingRight==false && moveX > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveX < 0)
        {
            Flip();
        }

        //прыжок 

        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            rb.velocity = new Vector2(moveX * jumpForce, moveY * jumpForce);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
