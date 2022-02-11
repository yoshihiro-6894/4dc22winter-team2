using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeUpperWalls : MonoBehaviour
{
    [SerializeField] private GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        for(float i = -8; i < -1; i++) {
            Instantiate(Wall, new Vector3((float)i, 1f, 0), Quaternion.identity);
        }
        for(float i = 2; i < 9; i++) {
            Instantiate(Wall, new Vector3((float)i, 1f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
