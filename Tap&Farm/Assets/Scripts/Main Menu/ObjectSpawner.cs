using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;
    public float objectLifetime = 5f;

    private void Start()
    {
        SpawnObject();
        GameObject newObject = Instantiate(objectPrefab, transform.position, transform.rotation);
        Destroy(newObject, objectLifetime);
    }

    private void SpawnObject()
    {
        float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("InstantiateObject", spawnTime);
    }

    private void InstantiateObject()
    {
        GameObject newObject = Instantiate(objectPrefab, transform.position, transform.rotation);
        Destroy(newObject, objectLifetime);
        SpawnObject();
    }
}