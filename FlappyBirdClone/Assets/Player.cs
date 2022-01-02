using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private float startingTime;
    public float jumpBetweenTime;
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && Time.time >= startingTime)
        {
            rb.velocity = new Vector2(0f, 1f) * Time.fixedDeltaTime * speed;
            startingTime = Time.time + jumpBetweenTime;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Obstacle")
        {
            Obstacle.IsGameEnded = true;
            rb.bodyType = RigidbodyType2D.Static;
            Invoke("Restart", 1f);
        }

    }

    void OnTriggerEnter2D()
    {
        Score.Point++;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
