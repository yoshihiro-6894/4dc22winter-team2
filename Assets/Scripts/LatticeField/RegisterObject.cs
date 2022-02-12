using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RegisterObject : MonoBehaviour
{
    public Vector2 LatticeWidth = Vector2.one;

    [SerializeField] private Vector2Int latticePosition = Vector2Int.zero; 

    public Vector2Int LatticePosition 
    {
        get 
        {
            return latticePosition;
        }
        set 
        {
            if(Moveable(value))
            {
                Debug.Log("set!");
                latticePosition = value;
                transform.position = GetWorldPosition(latticePosition);
            }
            else
            {
                Debug.Log("stay!");
            }
        }
    }

    void Awake()
    {
        gameObject.AddComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ワールド座標に近い格子位置に置く 
    public void Init()
    {
        Vector2Int lp = GetLatticePosition(transform.position);
        transform.position = new Vector3(
            lp.x,
            lp.y,
            0
        );
        latticePosition = lp; 
    }

    public void MoveTo(Vector2Int dir)
    {
        transform.DOMove(transform.position + new Vector3(dir.x, dir.y, 0), 1);
        latticePosition = dir;
    }

    public bool TryPut()
    {
        return Moveable(Vector2Int.zero);
    }

    public bool Moveable(Vector2Int dir) 
    {
        return false;
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