using UnityEngine;

public class ElevatorScript : MonoBehaviour
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

        movement.y = (Mathf.Sin(time * 2.0f) * 0.75f) + og_position.y;

        transform.position = movement;
    }
}
