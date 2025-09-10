using UnityEngine;
using UnityEngine.UIElements;

public class WaterScript : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 og_position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = transform.position;
        og_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        movement.y = (Mathf.Sin(time*1.5f)*0.25f)+og_position.y;
        movement.x = (Mathf.Sin(time * 0.5f)) + og_position.x;

        transform.position = movement;
    }
}
