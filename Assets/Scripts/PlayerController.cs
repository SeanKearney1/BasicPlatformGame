using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject doubleJumpHatLocation;
    Rigidbody2D rb;
    private float input_horizontal;
    private float input_vertical;
    public float horizontalMoveSpeed;
    public float verticalMoveSpeed;
    private int maxnumjumps;
    private int numjumps;

    private Vector3 TP_Location = new Vector3(0, 0, 0);

    private GameObject TP_Coin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello from Redball!!!");
        rb = GetComponent<Rigidbody2D>();

        input_vertical = 6;
        horizontalMoveSpeed = 5;
        verticalMoveSpeed = 10;

        maxnumjumps = 1;
        numjumps = maxnumjumps;
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerLateral();
        jump();

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
        //print("numjumps == " + numjumps);
        if (Input.GetKeyDown(KeyCode.Space) && numjumps < maxnumjumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y + input_vertical);
            numjumps++;
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
            //print("Max jumps now 0!!!!");
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            //string coin_str = collision.gameObject.GetComponent<CoinScript>().getTestString();
            maxnumjumps++;
            print("Max Jumps is now " + maxnumjumps);
        }
        else if (collision.gameObject.CompareTag("Hat"))
        {
            GameObject hat = collision.gameObject;
            equipDoubleJumpHat(hat);
        }

        else if (collision.CompareTag("KillFloor"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }


    private void equipDoubleJumpHat(GameObject hat)
    {
        print("IN HAT");
        hat.transform.position = this.transform.position;
        hat.transform.rotation = this.transform.rotation;
        hat.gameObject.transform.SetParent(this.gameObject.transform);

        hat.GetComponent<CircleCollider2D>().enabled = false;
    }


    public void setTpLocation(GameObject coin)
    {
        if (TP_Coin != null)
        {
            Destroy(TP_Coin);
        }
        TP_Coin = coin;
        TP_Location = coin.transform.position;
    }

    public void TpPlayer()
    {
        this.transform.position = TP_Location;
        Destroy(TP_Coin);
    }
}

