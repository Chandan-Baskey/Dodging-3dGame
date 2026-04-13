using UnityEngine;

public class Gamemanager1 : MonoBehaviour
{
    public GameObject store;
    public float maxX;

    public Transform spawnPoint;
    public 
    void Start()
    {
        InvokeRepeating("SpawnStore", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStore()
    {
        Vector3 SpawnPos = spawnPoint.position;
        SpawnPos.x = Random.Range(-maxX, maxX);
        //Vector3 spawnPos = new Vector3(randomX, spawnPoint.position.y, spawnPoint.position.z);
        Instantiate(store, SpawnPos, Quaternion.identity);
    }
}
