using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 20f;
    public float jumpForce;
    private Rigidbody2D rb;

    private bool facingRight = true;
    private Animator anim;

    public bool Grounded = false;
    public Transform GroundCheck;
    public float GroundRadius = 0.2f;
    public LayerMask whatIsGround;

   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    [System.Obsolete]
    private void FixedUpdate()
    {
       
        float moveX = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(moveX));
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        rb.MovePosition(rb.position + Vector2.right * moveX * speed *Time.deltaTime);

        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, whatIsGround);
        anim.SetBool("Grounded", Grounded);
        anim.SetFloat("vSpeed", rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            anim.SetBool("Grounded", false);
            rb.AddForce(new Vector2(0, 15000f));
        }

        if (!facingRight && moveX > 0)
        {
            Flip();
        } else if (facingRight && moveX < 0)
        {
            Flip();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }




    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
