using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private SnakeInputActions snakeInputActions;
    
    private void Start()
    {
        snakeInputActions = new SnakeInputActions();
        snakeInputActions.Snake.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = snakeInputActions.Snake.Move.ReadValue<Vector2>();
        Debug.Log(inputVector);
        return inputVector.normalized; 
    }
}
