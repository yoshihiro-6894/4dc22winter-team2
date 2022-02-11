using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDrawGizmos()
    {
#if UNITY_EDITOR
    UnityEditor.Handles.Label(transform.position, name);
#endif
    }
}
