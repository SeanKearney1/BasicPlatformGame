using System;
using UnityEngine;

public class TPExitCoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("COLLISION OCCURED!!!!!");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().setTpLocation(this.gameObject);
            this.transform.position = collision.transform.position;
            this.transform.rotation = collision.transform.rotation;
            this.gameObject.transform.SetParent(collision.gameObject.transform);
        }
    }
}
