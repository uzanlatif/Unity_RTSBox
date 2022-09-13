using System.Collections.Generic;
using UnityEngine;

public class UnitSelections : MonoBehaviour
{
    public List<GameObject> unitList = new List<GameObject>();
    public List<GameObject> unitsSelected = new List<GameObject>();

    private static UnitSelections _instance;
    public static UnitSelections Instance {get {return _instance; }}

    private void Awake() {
        if(_instance != null && _instance != this){

            Destroy(this.gameObject);
        }

        else{

            _instance=this;

        }
    }

    public void DragSelect(GameObject unitToAdd){
        if(!unitsSelected.Contains(unitToAdd)){
            unitsSelected.Add(unitToAdd);

            //disini object select diaktifkan
            unitToAdd.transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    public void DeselectAll(){

        foreach(var unit in unitsSelected){

            //deaktivasi object select
            unit.transform.GetChild(0).gameObject.SetActive(false);
        }
        unitsSelected.Clear();
    }
}
