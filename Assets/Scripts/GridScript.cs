using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour 
{
    [SerializeField] private Grid grid;
    [SerializeField] private Transform cellPrefab;
    [SerializeField] private int width, height;
    public Dictionary<Vector3Int, Transform> cells;

    private void Start()
    {
        cells = new Dictionary<Vector3Int, Transform>();
        
        for (int x = -width / 2; x <= width / 2; x++)
        {
            for (int y = -height / 2; y <= height / 2; y++)
            {
                Vector3Int cellPos = new Vector3Int(x, y, 0);
                Vector3 worldPosition = grid.GetCellCenterWorld(cellPos);
                Transform cell = Instantiate(cellPrefab, worldPosition, Quaternion.identity);
                
                bool isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                cell.GetComponent<TileScript>().Init(isOffset);
                cells[cellPos] = cell;
            }
        }
    }
}
