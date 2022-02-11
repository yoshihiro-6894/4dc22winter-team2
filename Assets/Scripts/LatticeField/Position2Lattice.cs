using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position2Lattice : MonoBehaviour
{
    // 16:9とかじゃないです
    public Vector2 LatticeWidth { get { return latticeWidth; } private set { latticeWidth = value; } }

    [SerializeField] private Vector2 latticeWidth;

    void Start()
    {
    }

    public Vector2Int GetLatticePosition(Vector3 pos)
    {
        return new Vector2Int((int)(pos.x / LatticeWidth.x), (int)(pos.y / LatticeWidth.y));
    }

    public Vector3 GetWorldPosition(Vector2Int pos)
    {
        return new Vector3(
            pos.x * LatticeWidth.x,
            pos.y * LatticeWidth.y,
            0
        );
    }

}
