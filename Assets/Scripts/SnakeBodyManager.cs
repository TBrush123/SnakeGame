using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnakeBodyManager : MonoBehaviour
{
    [SerializeField] private Snake snake;
    [SerializeField] private int size;
    [SerializeField] private GameInput gameInput;

    public List<Vector3Int> SnakeBodyCells;
    
    private Vector3Int moveDirection = Vector3Int.right;
    private bool _isMoving = false;
    
    public event Action OnSnakeMove;

    private void Start()
    {
        SnakeBodyCells = new List<Vector3Int>()
        {
            new Vector3Int(0, 0),
            new Vector3Int(-1, 0),
            new Vector3Int(-1, -1),
        };
    }

    private void Update()
    {
        moveDirection = gameInput.GetMovementVector();
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        if (_isMoving) yield break;
        _isMoving = true;
        
        yield return new WaitForSeconds(0.2f);
        
        SnakeBodyCells.RemoveAt(SnakeBodyCells.Count - 1);
        Vector3Int newHeadPosition = SnakeBodyCells[0] + moveDirection;
        SnakeBodyCells.Insert(0, newHeadPosition);
        OnSnakeMove?.Invoke();
        
        _isMoving = false;
    }
    
}
