using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Snake : MonoBehaviour
{
    [SerializeField] private int initialSize;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SnakeBodyManager snakeBodyManager;
    [SerializeField] private Transform bodyPrefab;
    [SerializeField] private GridScript grid;

    private void Start()
    {
        snakeBodyManager.OnSnakeMove += Move;
    }

    private void Move()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Vector3Int cell in snakeBodyManager.SnakeBodyCells)
        {
            Vector3 bodyPosition = grid.cells[cell].position;
            Transform newChild = Instantiate(bodyPrefab, bodyPosition, Quaternion.identity);
        }
    }
}