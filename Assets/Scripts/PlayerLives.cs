
using UnityEngine;
using UnityEngine.UI;
public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public GameObject explosionEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TakeDamage()
    {

        lives -= 1; //take away a live from the player
        Instantiate(explosionEffect, transform.position, Quaternion.identity); // Create an explosion effect at the player's position
        for (int i = 0; i < livesUI.Length; i++)
        {
            if (i < lives)
            {
                livesUI[i].enabled = true;
            }
            else
            {
                livesUI[i].enabled = false;
                
            }
        }
        if (lives <= 0)
        {
            //Player is dead
            Destroy(gameObject);
            //Trigger Game Over
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If Enemy crashes into the player
        if (collision.collider.gameObject.tag == "Enemy")
        {
            TakeDamage();
            Destroy(collision.collider.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If Enemy Projectile hits the player
        if (collision.CompareTag("EnemyProjectile"))
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }

}
