using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RegisterObject))]
public class MoveAlongLattice : MonoBehaviour
{
    [SerializeField] float timer;

    private RegisterObject registerObject;

    private Vector2Int restrictDirection;

    void Awake()
    {
        registerObject = gameObject.GetComponent<RegisterObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        registerObject.LatticePosition = new Vector2Int(-1, -2); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator greetyMove()
    {
        while(true)
        {
            yield return tryMove(Vector2Int.up);
            yield return tryMove(Vector2Int.down);
            yield return tryMove(Vector2Int.right);
            yield return tryMove(Vector2Int.left);
        }
    }

    private IEnumerator tryMove(Vector2Int dir)
    {
        if(dir != restrictDirection && registerObject.latticeField.Exists(registerObject.LatticePosition + dir))
        {
            restrictDirection = -dir;
            yield return MoveTo(dir, 1 / timer);
        }
    }
    IEnumerator MoveTo(Vector2Int direction, float speed)
    {
        /*
        Vector2Int targetPos = transform.position + direction;
        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
            yield return null;
        }

        transform.position = targetPos;
        registerObject.LatticePosition = new Vector2Int((int)targetPos.x, (int)targetPos.y, 0);
        */
        yield return null;
    }
}
