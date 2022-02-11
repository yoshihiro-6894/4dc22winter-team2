using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterObject : MonoBehaviour
{
    [SerializeField] private LatticeField latticeField;

    // Start is called before the first frame update
    void Start()
    {
        latticeField.SetObject(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}