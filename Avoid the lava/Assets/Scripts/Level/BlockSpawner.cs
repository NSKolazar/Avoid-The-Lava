using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    [SerializeField] public GameObject obstaclePrefab;
    [SerializeField] public Rigidbody rb;

    [SerializeField] public float timeBetweenWaves = 10f;

    [SerializeField] private float timeToSpawn = 2f;
    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnObstacles()
    {
        int randomIndex = Random.Range(0,spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i) 
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
        
    }


}
