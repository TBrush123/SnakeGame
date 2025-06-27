using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Snake : MonoBehaviour
{
    [SerializeField] private int initialSize;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SnakeBodyManager snakeBodyManager;
    [SerializeField] private Transform bodyPrefab;

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

        foreach (Vector2Int cell in snakeBodyManager.SnakeBodyCells)
        {
            Vector3 newCell = new Vector3(cell.x, cell.y, -0.1f);
            Transform newChild = Instantiate(bodyPrefab, transform);
            newChild.transform.localPosition = newCell;
        }
    }
}