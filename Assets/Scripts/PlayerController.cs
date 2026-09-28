using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour

{
    public float speed = 5.0f;
    public float turnSpeed;

    public InputAction MoveAction;
    public Vector2 moveInput;

    void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        //Move the vehicle forward
        moveInput = MoveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
