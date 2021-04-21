using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector2 movementInputVector;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.position += new Vector3(movementInputVector.x, movementInputVector.y) * speed * Time.deltaTime;
    }

    public void Move(InputAction.CallbackContext context)
    {
        movementInputVector = context.ReadValue<Vector2>();
    }
}
