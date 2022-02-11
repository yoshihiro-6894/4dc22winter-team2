using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterObject : MonoBehaviour
{
    [SerializeField] private LatticeField latticeField;

    [SerializeField] private Vector2Int latticePosition;

    // Start is called before the first frame update
    void Start()
    {
        latticeField.SetPos(this.gameObject, latticePosition);

        latticeField.SetObject(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}