using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostManager : MonoBehaviour
{
    public float MaxCostPoint = 200;

    public float nowCostPoint;
    private int UInowCostPoint;

    [Header("コストのチャージスピード")]public float ChargeSpeed;

    public Text UItext;

    // Start is called before the first frame update
    void Start()
    {
        nowCostPoint = 0;
        UInowCostPoint = 0;
        UItext.text = UInowCostPoint.ToString() + "/" + MaxCostPoint.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        AddPoint(ChargeSpeed * Time.deltaTime);
    }

    public void AddPoint(float AddValue)
    {
        nowCostPoint += AddValue;

        if (nowCostPoint >= MaxCostPoint)
            nowCostPoint = MaxCostPoint;

        UInowCostPoint = (int)nowCostPoint;

        UItext.text = UInowCostPoint.ToString() + "/" + MaxCostPoint.ToString();
    }

    public void AddPoint(int AddValue)
    {
        nowCostPoint += AddValue;

        if (nowCostPoint >= MaxCostPoint)
            nowCostPoint = MaxCostPoint;

        UInowCostPoint = (int)nowCostPoint;

        UItext.text = UInowCostPoint.ToString() + "/" + MaxCostPoint.ToString();
    }

    public void DownPoint(int DownValue)
    {
        nowCostPoint -= DownValue;

        if (nowCostPoint <= 0)
            nowCostPoint = 0;

        UInowCostPoint = (int)nowCostPoint;

        UItext.text = UInowCostPoint.ToString() + "/" + MaxCostPoint.ToString();
    }
}
