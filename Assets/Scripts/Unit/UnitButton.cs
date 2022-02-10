using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitButton : MonoBehaviour
{
    public GameObject UnitData;

    public GameObject Unitmanager;

    public int Cost;

    private void Start()
    {
        Cost = UnitData.GetComponent<Unit>().Cost;
    }

    public void CopyUnitData()
    {
        Unitmanager.GetComponent<UnitManager>().SelectedUnit = UnitData;
    }
}
