using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileShoot : MonoBehaviour
{

    public GameObject projectilePrefab;
    public InputActionReference fire;
    void OnEnable()  => fire.action.Enable();
    void OnDisable() => fire.action.Disable();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fire.action.triggered)
        {
            //Debug.Log("Fire!");
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
