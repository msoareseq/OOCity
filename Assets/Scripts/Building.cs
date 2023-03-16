using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class Building : MonoBehaviour
{
    protected GameManager gameManager;
    public enum BuildingType { Residential, Office, Commercial };

    public string BuildingName //ENCAPSULATION
    {
        get { return buildingName; }
        set { buildingName = value; }
    }
    
    public int NumberOfFloors
    {
        get { return numberOfFloors; }
        set { numberOfFloors = Mathf.Clamp(value, 0, 10); }
    }
    
    public float TaxRate
    {
        get { return taxRate; }
    }

    public int Citizens { get => citizens; }
    public BuildingType TypeOfBuilding { get => typeOfBuilding; set => typeOfBuilding = value; }

    protected string buildingName;
    protected int numberOfFloors;
    protected float taxRate;
    protected int citizens;
    protected BuildingType typeOfBuilding;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //citizens = UnityEngine.Random.Range(0, 2);

        CalculateTaxRate();

        InvokeRepeating(nameof(PayTaxes), 5f, 30f);

    }

    void GenerateBuildingName()
    {
        switch (typeOfBuilding)
        {
            case BuildingType.Residential:
                buildingName = "Residential Building";
                break;
            case BuildingType.Office:
                buildingName = "Office Building";
                break;
            case BuildingType.Commercial:
                buildingName = "Commercial Building";
                break;
        }
    }

    void Update()
    {
        
    }
    // ABSTRACTION
    protected abstract void PayTaxes();
    protected abstract void DoAction();

    protected void CalculateTaxRate() 
    { 
        switch (typeOfBuilding)
        {
            case BuildingType.Residential:
                taxRate = 0.01f;
                break;
            case BuildingType.Office:
                taxRate = 0.02f;
                break;
            case BuildingType.Commercial:
                taxRate = 0.03f;
                break;
            default:
                taxRate = 0.01f;
                break;
        }
    }
}
