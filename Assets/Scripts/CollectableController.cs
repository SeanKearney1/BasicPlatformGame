using Unity.VisualScripting;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;
    private float randomized_speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomized_speed = Random.Range(0.8f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft();
    }

    private void moveLeft()
    {
        rb.linearVelocity = new Vector2(Speed * randomized_speed * -1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CollectableKillWall"))
        {
            Destroy(this.gameObject);
        }
    }

}
