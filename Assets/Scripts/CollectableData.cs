using UnityEngine;

public class CollectableData : MonoBehaviour
{
    public int collectableValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void destroyCollectable()
    {
        Destroy(this.gameObject);
    }

    public int getCollectableValue()
    {
        return collectableValue;
    }
}
