using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;

    private Vector2 _moveDirection;

    public InputActionReference move;


    // Update is called once per frame
    void Update()
    { 
        
         //Sees what button is pressed and applies it to moveDirection
         //Remember to hook up in the inspector 
        _moveDirection = move.action.ReadValue<Vector2>();
        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime); 
    }

    void FixedUpdate()
    {
        //Moves the player in the direction of moveDirection
        rb.MovePosition(rb.position + _moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
