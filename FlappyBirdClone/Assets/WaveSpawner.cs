using UnityEngine;


public class WaveSpawner : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 randomPos;
    private float startingTimeObstacle;
    public float spawnBetweenTime;
    void Update()
    {
        if (Time.time >= startingTimeObstacle && Obstacle.IsGameEnded == false)
        {
            randomPos = new Vector3(transform.position.x, Random.Range(-1.62f, 3.37f), 0f);
            Instantiate(obstacle, randomPos, transform.rotation);
            startingTimeObstacle = Time.time + spawnBetweenTime;
           
        }
    }

    
}
