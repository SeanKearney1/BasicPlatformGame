using UnityEngine;
using UnityEngine.UIElements;

public class RotatererScript : MonoBehaviour
{
    public Quaternion Rotation;
    public int SpinSpeed = 100;
    public int SpinOffset = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Rotation = Quaternion.Euler(0, 0, (Time.time + SpinOffset) *SpinSpeed);
        transform.rotation = Rotation;
    }
}
