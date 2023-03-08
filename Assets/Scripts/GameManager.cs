using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string CityName
    {
        get { return cityName; }
        set { cityName = value; }
    }

    public float CityCash
    {
        get { return cityCash; }
    }
    
    public int CityPopulation
    {
        get { return cityPopulation; }
    }

    public List<GameObject> CityBuildings = new List<GameObject>();

    private string cityName;
    private float cityCash;
    private int cityPopulation;
    private int simulationDay;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CountPopulation()
    {
        cityPopulation = 0;
        foreach (GameObject building in CityBuildings)
        {
        }
    }

}
