using System.Collections;
using UnityEngine;

public class ProductionBuilding : Building
{
    [SerializeField] private Product _product;
    [SerializeField] private int _interval;
    [SerializeField] Clock.DayCycle _productingCycle;
    
    private void OnEnable()
    {
        Clock.CycleChanged += Creating;
    }

    private void OnDisable()
    {
        Clock.CycleChanged -= Creating;
    }


    private void Creating()
    {
        Instantiate(_product);
    }
}
