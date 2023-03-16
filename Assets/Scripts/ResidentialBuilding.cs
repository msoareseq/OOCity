using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentialBuilding : Building // INHERITANCE
{
    public string initialBuildingName;
    public int initialNumberOfFloors;
    public int initialCitizens;
    public BuildingType initialBuildingType;

    private void Awake()
    {
        buildingName = initialBuildingName;
        numberOfFloors = initialNumberOfFloors;
        citizens = initialCitizens;
        typeOfBuilding = initialBuildingType;
    }

    protected override void DoAction()
    {
        citizens = Mathf.Clamp(citizens++, 0, 5);
    }

    protected override void PayTaxes()
    {
        gameManager.AddCash(citizens * taxRate * 100);
    }
        
}
