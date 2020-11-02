
using UnityEngine;

public class fishCntrl : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;

    private bool faceRight = true;

    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"), moveY = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + new Vector2(moveX,moveY) * speed * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x + moveX * speed, transform.position.y + moveY * speed, transform.position.y);

        //if (Input.GetKeyDown(KeyCode.Space))
        //   rb.AddForce(Vector2.up * 2000);


        if (moveX > 0 && !faceRight)
        {
            flip();
        }
        else
        {
            if (moveX < 0 && faceRight)
            {
                flip();
            }
        }

        if (moveX == 0 && moveY == 0)
        {
            anim.SetBool("isrun", false);
        }
        else
        {
            anim.SetBool("isrun", true);

        }
    }

    void flip ()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
