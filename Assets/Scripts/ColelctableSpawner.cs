using UnityEngine;

public class ColelctableSpawner : MonoBehaviour
{
    public GameObject lowestYSpawn;
    public GameObject highestYSpawn;

    public GameObject yellowCollectable;
    public GameObject redCollectable;
    public GameObject greenCollectable;

    private int randomPrefab;

    private GameObject collectableToSpawn;

    private float time;
    public float delay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= delay)
        {
            spawnObject();
            time = 0;
        }
    }


    private void spawnObject()
    {
        randomPrefab = Random.Range(0, 3);

        if (randomPrefab == 0) { collectableToSpawn = Instantiate(redCollectable); }
        else if (randomPrefab == 1) { collectableToSpawn = Instantiate(greenCollectable); }
        else if (randomPrefab == 2) { collectableToSpawn = Instantiate(yellowCollectable); }

        Vector2 spawn_vec = new Vector2(0, 0);

        spawn_vec.x = lowestYSpawn.transform.position.x;
        spawn_vec.y = Random.Range(lowestYSpawn.transform.position.y,highestYSpawn.transform.position.y);

        collectableToSpawn.transform.position = spawn_vec;
    }
}
