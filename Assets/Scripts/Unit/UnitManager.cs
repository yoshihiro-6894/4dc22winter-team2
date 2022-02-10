using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitManager : MonoBehaviour
{
    public GameObject SelectedUnit;

    private Vector3 mousePos;

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
            Instantiate(SelectedUnit, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);
            SelectedUnit = null;
            //コスト周りの実装をしないといけない
        }
    }
}
