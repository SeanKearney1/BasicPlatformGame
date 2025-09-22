using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("COLLISION OCCURED!!!!!");
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        
    }

    public string getTestString()
    {
        return "Hello from coin";
    }
}
