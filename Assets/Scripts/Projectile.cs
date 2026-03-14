using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionEffect;
    private PointManager pointManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(100);
            Destroy(gameObject);
        }

        if(collision.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }
}
