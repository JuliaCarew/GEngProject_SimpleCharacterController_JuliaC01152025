using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GameInput.IPlayerActions
{
    private GameInput gameInput;

    void Awake()
    {
        gameInput = new GameInput();
        gameInput.Player.Enable(); // enable input system

        gameInput.Player.SetCallbacks(this);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Move input recieving: " + context.ReadValue<Vector2>());
    }

}

public static class InputActions // can expand to add more actions for the player
{
    public static Action<Vector2> MoveEvent;    
}
