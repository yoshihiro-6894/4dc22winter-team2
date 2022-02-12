using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitManager : MonoBehaviour
{
    public GameObject SelectedUnit;

    public CostManager costmanager;

    private Vector3 mousePos;

    /// <summary>
    /// 選択したユニットを置いたかどうか
    /// </summary>
    public bool UnitPlaced;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 何らかのボタンが押された場合は止める
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0) && SelectedUnit != null)
        {
            mousePos = Input.mousePosition;
            mousePos.z = 10;

            //RaycastHit2D hit = Physics2D.CircleCast(Camera.main.ScreenToWorldPoint(mousePos), 0.1f, Vector2.up);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (!hit2d|| hit2d.transform.gameObject.tag != "DontSetUnit")
            {
                GameObject g = Instantiate(SelectedUnit, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);
                RegisterObject ro = g.GetComponent<RegisterObject>();
                ro.Init();

                costmanager.DownPoint(SelectedUnit.GetComponent<Unit>().Cost);
                UnitPlaced = true;
                SelectedUnit = null;
            }
        }
    }
}
