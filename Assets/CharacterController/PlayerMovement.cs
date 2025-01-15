using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private InputManager inputManager;

    public Vector2 moveDirection = new Vector2(-1.00f, 0.00f);

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        //HandlePlayerMove();
    }

    void HandlePlayerMove(Vector2 moveDirection)
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }

    private void OnEnable()
    {
        InputActions.MoveEvent += HandlePlayerMove;
    }
    private void OnDisable()
    {
        InputActions.MoveEvent -= HandlePlayerMove;
    }
}
