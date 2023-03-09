using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected GameManager gameManager;
    public enum BuildingType { Residential, Office, Commercial };

    public string BuildingName
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

    protected string buildingName;
    protected int numberOfFloors;
    protected float taxRate;
    protected int citizens;
    protected BuildingType _typeOfBuilding;
    

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        citizens = Random.Range(0, 2);

        CalculateTaxRate();

        InvokeRepeating(nameof(PayTaxes), 5f, 30f);

    }

    void Update()
    {
        
    }

    protected abstract void PayTaxes();
    protected abstract void DoAction();

    protected void CalculateTaxRate() 
    { 
        switch (_typeOfBuilding)
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
