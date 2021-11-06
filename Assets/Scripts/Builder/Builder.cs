using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    Building _building;
    BuildSlot _buildSlot;

    public void Build(Building building)
    {
        Instantiate(building);
    }

    public void SelectBuilding(Building building)
    {
        _building = building;
    }
}
