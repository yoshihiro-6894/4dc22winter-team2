using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitButton : MonoBehaviour
{
    public GameObject UnitData;

    public GameObject manager;

    private void Start()
    {
        
    }

    public void CopyUnitData()
    {
        manager.GetComponent<UnitManager>().SelectedUnit = UnitData;
    }
}
