using UnityEngine;

public class AnimalController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float stopSpeedThreshold = 0.01f;
    private GameManager gameManager;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public bool IsStopped()
    {
        return rb.velocity.magnitude < stopSpeedThreshold;
    }



    // 他のオブジェクトとの接触を検出
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("stage") && this.gameObject.tag == "Player")
        {

            this.gameObject.tag = "stage";

            gameManager.ok();
        }
    }

}

