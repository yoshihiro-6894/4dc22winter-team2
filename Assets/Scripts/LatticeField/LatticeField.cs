using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatticeField : MonoBehaviour
{
    [SerializeField] private Vector2 latticeWidth; 

    private Dictionary<Vector2Int, GameObject> latticeObjects;

    public Position2Lattice position2Lattice;

    void Awake()
    {
        position2Lattice = new Position2Lattice(latticeWidth); 

        latticeObjects = new Dictionary<Vector2Int, GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetObject(GameObject g)
    {
        Vector2Int pos = position2Lattice.GetLatticePosition(g.transform.position);
        SetObject(g, pos);
    }

    public void SetObject(GameObject g, Vector2Int pos)
    {
        latticeObjects.Add(pos, g);
    }

    public void SetPos(GameObject g, Vector2Int latticePos)
    {
        g.transform.position = new Vector3(
            latticePos.x * position2Lattice.latticeWidth.x,
            latticePos.y * position2Lattice.latticeWidth.y,
            0
        );
    }
}
