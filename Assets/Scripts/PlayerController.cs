using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    private float input_horizontal;
    private float input_vertical;
    public float horizontalMoveSpeed;
    public float verticalMoveSpeed;
    private int maxnumjumps;
    private int numjumps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello from Redball!!!");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerLateral();
        jump();
        input_vertical = 20;
        horizontalMoveSpeed = 5;
        verticalMoveSpeed = 10;

        maxnumjumps = 1;
        numjumps = maxnumjumps;
}

    private void movePlayerLateral()
    {
        //0 - no button pressed.
        //1 - right arrow or d pressed.
        //2 - left arrow or a pressed.
        input_horizontal = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(horizontalMoveSpeed * input_horizontal, rb.linearVelocity.y);

    }
    private void jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && numjumps <= maxnumjumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, verticalMoveSpeed * input_vertical);
            numjumps++;
        }
        else
        {
            print("CANNOT JUMP!!!!!");
        }
    }


    private void flipPlayerSprite(float inputhorizontal)
    {
        if (inputhorizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (inputhorizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 100, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            numjumps = 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PinkCollectable"))
        {
            string coin_str = collision.gameObject.GetComponent<CoinScript>().getTestString();
            print(coin_str);
        }
    }
}

