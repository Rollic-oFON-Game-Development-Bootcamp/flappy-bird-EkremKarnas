using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float obstacleSpeed;
    public static bool IsGameEnded;


    void Start()
    {
        IsGameEnded = false;
    }

    void FixedUpdate()
    {
        if (IsGameEnded == false)
        {
            rb.MovePosition(rb.position + new Vector2(-1f, 0f) * Time.fixedDeltaTime * obstacleSpeed);
            Invoke("ObstacleDestroyer", 8f);
        }

    }

    void ObstacleDestroyer()
    {
        Destroy(gameObject);
    }
}
