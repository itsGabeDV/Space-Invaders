using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject EnemyProjectile;
    public float spawnTimer;
    public float spawnMax = 15f;
    public float spawnMin = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax); // Set the initial spawn timer to a random value between spawnMin and spawnMax
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <=0){
            Instantiate(EnemyProjectile, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax); // Reset the timer to a new random value
        }
    }
}
