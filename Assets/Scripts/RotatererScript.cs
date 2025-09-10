using UnityEngine;

public class RotatererScript : MonoBehaviour
{
    public Quaternion Rotation = new Quaternion(0, 0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Rotation = new Quaternion(0, 0, (Time.time*10)%1, 0);
        transform.rotation = Rotation;
        //print(Rotation);
    }
}
