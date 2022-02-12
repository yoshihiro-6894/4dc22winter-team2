using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UnitButton : MonoBehaviour
{
    public GameObject UnitData;

    public UnitManager Unitmanager;

    public CostManager costmanager;

    public Slider cooltimebar;

    public Text CostText;

    public int RequireCost;

    public float coolTime;
    private float time = 0;

    /// <summary>クールタイムかどうか</summary>
    public bool isCoolTime;
    /// <summary>召喚できるか</summary>
    public bool AbleSummon;

    public bool ChangAble;

    private void Start()
    {
        RequireCost = UnitData.GetComponent<Unit>().Cost;
        coolTime = UnitData.GetComponent<Unit>().CoolTime;
        CostText.text = RequireCost.ToString();
        ChangeInteractable(false);
    }

    private void Update()
    {
        if (isCoolTime)
        {
            if (time < coolTime)
            {
                time += 1 * Time.deltaTime;
                cooltimebar.value = time / coolTime * 100;
            }
            else
            {
                time = 0;
                cooltimebar.value = time / coolTime * 100;
                isCoolTime = false;
                cooltimebar.gameObject.SetActive(false);
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

        if (ChangAble && Unitmanager.UnitPlaced)
        {
            ChangAble = false;
            isCoolTime = true;
            cooltimebar.gameObject.SetActive(true);
            //Debug.Log(UnitData + "のクールタイムがオン");
            ChangeInteractable(false);
            Unitmanager.UnitPlaced = false;
        }

        if (Unitmanager.SelectedUnit == UnitData)
            ChangAble = true;
        else
            ChangAble = false;
    }


    /// <summary>
    /// Buttonが押されたときに呼び出される関数
    /// </summary>
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
