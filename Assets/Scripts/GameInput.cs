using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private Vector2Int moveDirection = Vector2Int.zero;
    
    public Vector2Int GetMovementVector()
    {
        if (Input.GetKey(KeyCode.W)) moveDirection = Vector2Int.up;
        if (Input.GetKey(KeyCode.A)) moveDirection = Vector2Int.left;
        if (Input.GetKey(KeyCode.S)) moveDirection = Vector2Int.down;
        if (Input.GetKey(KeyCode.D)) moveDirection = Vector2Int.right;
        
        return moveDirection; 
    }
}
