using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeUnderWalls : MonoBehaviour
{
    [SerializeField] private GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = -8; i <= 8; i++) {
            Instantiate(Wall, new Vector3((float)i, -2f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
