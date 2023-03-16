using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonResidentialBuilding : Building
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
        citizens = Random.Range(0, 20);
    }
    // POLYMORPHISM
    protected override void PayTaxes()
    {
        gameManager.AddCash(citizens * taxRate * 10);
    }
       
}
