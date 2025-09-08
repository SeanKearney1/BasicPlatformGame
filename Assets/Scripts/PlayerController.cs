using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    private float input_horizontal;
    public float horizontalMoveSpeed;
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

    }
}

