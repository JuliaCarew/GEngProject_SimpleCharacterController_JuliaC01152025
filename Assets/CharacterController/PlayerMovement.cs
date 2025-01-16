using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    
    [SerializeField]
    private float moveSpeed = 5.0f;
    public Vector2 moveVector = Vector2.zero;

    void Awake()
    {
        characterController = this.GetComponent<CharacterController>();
        InputActions.MoveEvent += UpdateMoveVector;
    }

    private void UpdateMoveVector(Vector2 inputVector) // player input = moveVector(current vector2 from HandlePlayerMove)
    {
        moveVector = inputVector;
    }

    void HandlePlayerMove(Vector2 moveVector) // use .Move functionality to move player on set veriables, gets updated by UpdateMoveVector() method
    {
        characterController.Move(moveVector * moveSpeed * Time.deltaTime);
    }

    private void Update() // moving player by character controller component every frame
    {
        HandlePlayerMove(moveVector);
    }
    private void OnDisable()
    {
        InputActions.MoveEvent -= UpdateMoveVector;
    }
}
