using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Snake : MonoBehaviour
{
    [SerializeField] private int initialSize;
    [SerializeField] private int size;
    [SerializeField] private Transform grid;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameInput gameInput;
    
    
    private Vector2Int snakeHead;
    private List<Vector2Int> snakeBody;
    
    public Vector2 moveDirection { get; set; }
    
    private void Update()
    {
        Vector2 movementVectorNormalized = gameInput.GetMovementVectorNormalized();
        rb.MovePosition(rb.position + movementVectorNormalized * (5f * Time.deltaTime));
    }
    
    
}
