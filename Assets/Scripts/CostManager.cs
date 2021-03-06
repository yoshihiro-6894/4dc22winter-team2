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

    public Slider CostBar;

    // Start is called before the first frame update
    void Start()
    {
        UInowCostPoint = 0;
        SetValueToUI();
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

        SetValueToUI();
    }

    public void AddPoint(int AddValue)
    {
        nowCostPoint += AddValue;

        if (nowCostPoint >= MaxCostPoint)
            nowCostPoint = MaxCostPoint;

        UInowCostPoint = (int)nowCostPoint;

        SetValueToUI();
    }

    public void DownPoint(int DownValue)
    {
        nowCostPoint -= DownValue;

        if (nowCostPoint <= 0)
            nowCostPoint = 0;

        UInowCostPoint = (int)nowCostPoint;

        SetValueToUI();
    }

    void SetValueToUI()
    {
        UItext.text = "MEIYO   "+UInowCostPoint.ToString("d3") + "/" + MaxCostPoint.ToString()+" P";
        CostBar.value = nowCostPoint / MaxCostPoint * 100;
    }
}
