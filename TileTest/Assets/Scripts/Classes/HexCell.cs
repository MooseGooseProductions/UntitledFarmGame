using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour
{
    public int width = 6;
    public int height = 6;

    public HexCell prefab;
    HexCell[] cells;

    void Awake()
    {
        cells = new HexCell[height * width];

        for (int i = 0, j = 0; i < height; i++)
        {
            for (int k = 0; k < width; k++)
            {
                CreateCell(k, i, j++);
            }
        }
    }

    void CreateCell(int k, int i, int j)
    {
        Vector3 p;
        p.x = k * 10f;
        p.y = 0f;
        p.z = i * 10f;

        HexCell cell = cells[j] = Instantiate<HexCell>(prefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = p;
    }
}
