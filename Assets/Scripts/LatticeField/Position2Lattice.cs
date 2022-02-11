using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position2Lattice
{
    // 16:9とか
    public Vector2 latticeWidth { get; private set; }

    public Position2Lattice(Vector2 w)    
    {
        latticeWidth = w; 
    }

    public Vector2Int GetLatticePosition(Vector2 pos)
    {
        return new Vector2Int((int)(pos.x / latticeWidth.x), (int)(pos.y / latticeWidth.y));
    }

}
