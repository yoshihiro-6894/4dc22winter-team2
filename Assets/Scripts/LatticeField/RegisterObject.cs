using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RegisterObject : MonoBehaviour
{
    [SerializeField] private GameObject LatticeSystem;

    [SerializeField] public Vector2Int latticePosition = Vector2Int.zero;

    private LatticeField latticeField;

    private Position2Lattice position2Lattice;


    void Awake()
    {
        latticeField = LatticeSystem.GetComponent<LatticeField>();

        position2Lattice = LatticeSystem.GetComponent<Position2Lattice>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPos(latticePosition);

        latticeField.SetObject(latticePosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTo(Vector2Int dir)
    {
        latticeField.SetObject(position2Lattice.GetLatticePosition(transform.position + new Vector3(dir.x, dir.y, 0)));
        transform.DOMove(transform.position + new Vector3(dir.x, dir.y, 0), 1);
        latticeField.RemoveObject(latticePosition);
    }

    public void SetPos(Vector2Int latticePos)
    {
        Debug.Log(latticePos);
        transform.position = new Vector3(
            latticePos.x * position2Lattice.LatticeWidth.x,
            latticePos.y * position2Lattice.LatticeWidth.y,
            0
        );
    }

}