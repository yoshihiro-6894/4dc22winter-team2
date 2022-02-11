using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatticeField : MonoBehaviour
{
    private List<Vector2Int> latticeObjects;

    void Awake()
    {
        latticeObjects = new List<Vector2Int>();
    }

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool Exists(Vector2Int pos)
    {
        return latticeObjects.Contains(pos);
    }

    public bool SetObject(Vector2Int pos)
    {
        if(latticeObjects.Contains(pos))
        {
            return false;
        }
        latticeObjects.Add(pos);
        return true;
    }

    public void RemoveObject(Vector2Int latticePos)
    {
        latticeObjects.Remove(latticePos);
    }

}
