using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private Vector3Int moveDirection = Vector3Int.zero;
    
    public Vector3Int GetMovementVector()
    {
        if (Input.GetKey(KeyCode.W)) moveDirection = Vector3Int.up;
        if (Input.GetKey(KeyCode.A)) moveDirection = Vector3Int.left;
        if (Input.GetKey(KeyCode.S)) moveDirection = Vector3Int.down;
        if (Input.GetKey(KeyCode.D)) moveDirection = Vector3Int.right;
        
        return moveDirection; 
    }
}
