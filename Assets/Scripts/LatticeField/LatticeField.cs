using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatticeField : MonoBehaviour
{
    [SerializeField] private Camera displayCamera;

    [SerializeField] private Vector2Int lattice; 

    private GameObject[,] latticeObjects;

    private Position2Lattice position2Lattice;

    //static private Vector2 latticeSize = new Vector2(Screen.width / lattice.x, Screen.height / lattice.y);

    void Awake()
    {
        position2Lattice = new Position2Lattice(lattice, new Vector2(Screen.width, Screen.height));

        latticeObjects = new GameObject[lattice.x, lattice.y];
        //latticeSize = new Vector2(Screen.width / lattice.x, Screen.height / lattice.y); 
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < lattice.x; i++) {
            for(int j = 0; j < lattice.y; j++) {
                latticeObjects[i, j] = null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetObject(gameObject g)
    {
        Vector2Int pos = GetLatticePosition(g.transform.position)
        latticeObjects[pos.x, pos.y] = g;
    }

}
