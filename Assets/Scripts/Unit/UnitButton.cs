using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitButton : MonoBehaviour
{
    public GameObject UnitData;

    public UnitManager Unitmanager;

    public CostManager costmanager;

    public int RequireCost;

    public float coolTime;
    private float time = 0;

    public bool isCoolTime;
    public bool AbleSummon;

    private void Start()
    {
        RequireCost = UnitData.GetComponent<Unit>().Cost;
        coolTime = UnitData.GetComponent<Unit>().CoolTime;
        ChangeInteractable(false);
    }

    private void Update()
    {
        if (isCoolTime)
        {
            if (time < coolTime)
            {
                time += 1 * Time.deltaTime;
            }
            else
            {
                time = 0;
                isCoolTime = false;
            }
        }
        else
        {
            if (costmanager.nowCostPoint >= this.RequireCost && !AbleSummon)
            {
                ChangeInteractable(true);
            }

            if (costmanager.nowCostPoint < this.RequireCost && AbleSummon)
            {
                ChangeInteractable(false);
            }
        }
    }

    public void CopyUnitData()
    {
        Unitmanager.SelectedUnit = UnitData;
    }

    private void ChangeInteractable(bool change)
    {
        GetComponent<Button>().interactable = change;
        AbleSummon = change;
    }
}
