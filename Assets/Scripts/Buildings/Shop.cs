using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    

    Builder builder;
    public List<Button> buttons;
    Dictionary<string, Building> _buildings;
    

    private void Start()
    {
      
    }

    public void PlantationSelect()
    {
        builder.SelectBuilding(_buildings["Ferm"]);
    }


}
