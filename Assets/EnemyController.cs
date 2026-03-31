using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PlayerController playerController;


    void Start()
    {
        float playerHeath = playerController.health;

    }

    // Update is called once per frame
    void Update()
    {
        float playerHealth = playerController.health;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
        }
    }
}
