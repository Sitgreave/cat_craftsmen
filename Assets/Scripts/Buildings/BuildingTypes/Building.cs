using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [SerializeField] private string _description;
    [SerializeField] private List<int> _income;
    [SerializeField] private List<int> _cost;
    private int _level;


}
