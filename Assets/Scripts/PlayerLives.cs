
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject); // Destroys the enemy that touched the player
            lives -= 1; //take away a live from the player
            Instantiate(explosionEffect, transform.position, Quaternion.identity); // Create an explosion effect at the player's position
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i >= lives)
                {
                    livesUI[i].enabled = false;
                }
                else
                {
                    livesUI[i].enabled = true;
                    
                }
            }

            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
