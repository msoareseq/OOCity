using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public enum BuildingType { Residential, Office, Commercial };

    public string BuildingName
    {
        get { return _buildingName; }
        set { _buildingName = value; }
    }
    
    public int NumberOfFloors
    {
        get { return _numberOfFloors; }
        set { _numberOfFloors = Mathf.Clamp(value, 0, 10); }
    }
    
    public float TaxRate
    {
        get { return _taxRate; }
    }

    protected string _buildingName;
    protected int _numberOfFloors;
    protected float _taxRate;
    protected BuildingType _typeOfBuilding;


    void Start()
    {
        CalculateTaxRate();
    }

    void Update()
    {
        
    }

    protected void PayTaxes()
    {

    }

    protected void CalculateTaxRate() 
    { 
        switch (_typeOfBuilding)
        {
            case BuildingType.Residential:
                _taxRate = 0.01f;
                break;
            case BuildingType.Office:
                _taxRate = 0.02f;
                break;
            case BuildingType.Commercial:
                _taxRate = 0.03f;
                break;
            default:
                _taxRate = 0.01f;
                break;
        }
    }
}
