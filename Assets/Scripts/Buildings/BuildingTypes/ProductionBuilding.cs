using System.Collections;
using UnityEngine;

public class ProductionBuilding : Building
{
    [SerializeField] private Product _product;
    [SerializeField] private int _interval;
    
    private void Start()
    {
        StartProductCreating();
    }
    void StartProductCreating() 
    {
        StartCoroutine(Creating(_interval));
    }

    IEnumerator Creating(float interval)
    {
        while (true)
        {
            Instantiate(_product);
            yield return new WaitForSeconds(interval);
        }
    }
}
