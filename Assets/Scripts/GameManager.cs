using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string CityName
    {
        get { return _cityName; }
        set { _cityName = value; }
    }

    public float CityCash
    {
        get { return _cityCash; }
    }
    
    public int CityPopulation
    {
        get { return _cityPopulation; }
    }

    private List<GameObject> _cityBuildings = new List<GameObject>();

    private string _cityName;
    private float _cityCash;
    private int _cityPopulation;
    private int _simulationDay;

    void Start()
    {
        Application.targetFrameRate = 60;
        _cityCash = 10000;
        _cityBuildings.AddRange(GameObject.FindGameObjectsWithTag("Building"));

        InvokeRepeating(nameof(CountPopulation), 1f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CountPopulation()
    {
        _cityPopulation = 0;
        foreach (GameObject building in _cityBuildings)
        {
            _cityPopulation += building.GetComponent<Building>().Citizens;
        }
    }

    public void AddCash(float ammount)
    {
        _cityCash += ammount;
    }

}
