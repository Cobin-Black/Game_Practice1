using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    
    Rigidbody2D playerRB;

    Vector2 playerDirection;
    public Player_Input playerControls;
    private InputAction playerMovement;

    public int moveSpeed;

    void Awake()
    {
        playerControls = new Player_Input();
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnEnable()
    {
        playerMovement = playerControls.Player.Movement;
        playerMovement.Enable();
    }

    void OnDisable()
    {
        playerMovement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = playerMovement.ReadValue<Vector2>();

        playerRB.linearVelocity = new Vector2(playerDirection.x * moveSpeed, playerDirection.y * moveSpeed);
    }
}
