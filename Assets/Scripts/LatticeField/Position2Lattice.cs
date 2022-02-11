using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position2Lattice
{
    // 16:9とか
    public Vector2Int LatticeSize { get; set; }

    public Vector2 ScreenSize { get; set; }

    private Vector2 latticeWidth;

    public Position2Lattice(Vector2Int l, Vector2 s)    
    {
        LatticeSize = l;

        ScreenSize = s; 

        latticeWidth = s / l;
    }

    public Vector2Int GetLatticePosition(Vector2 pos)
    {
        return new Vector2Int((int)(pos.x / latticeWidth.x), (int)(pos.y / latticeWidth.y));
    }

    public void SetLatticePosition(GameObject g)
    {


    }
}
