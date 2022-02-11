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
        registerObject.MoveTo(Vector2Int.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
