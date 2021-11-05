using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    

    Builder builder;
    public List<Button> buttons;
    public List<Building> buildings;
    Dictionary<Button, Building> selectBuilding;
    [MenuItem("MyMenu/Do Something")]
    public void SelectBuilding()
    {
        
    }
}
