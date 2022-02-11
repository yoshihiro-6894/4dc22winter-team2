using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(RegisterObject))]
public class MoveAlongLattice : MonoBehaviour
{
    private RegisterObject registerObject;

    void Awake()
    {
        registerObject = gameObject.GetComponent<RegisterObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(registerObject.Moveable(Vector2Int.right))
        {
            registerObject.MoveTo(new Vector2Int(1, 0));
        }
        if(registerObject.Moveable(Vector2Int.right))
        {
            registerObject.MoveTo(new Vector2Int(1, 0));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void searchMove()
    {
    }

}
