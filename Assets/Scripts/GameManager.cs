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

    public GameObject ActiveBuilding { get => _activeBuilding; }

    private List<GameObject> _cityBuildings = new List<GameObject>();

    private string _cityName;
    private float _cityCash;
    private int _cityPopulation;
    private int _simulationDay;

    [SerializeField]
    private UIHandler _uiHandler;

    private GameObject _activeBuilding;

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
        if (Input.GetMouseButtonDown(0))
        {
            // select an object using raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Building")
                {
                    _activeBuilding = hit.transform.gameObject;
                    Debug.Log(_activeBuilding.name);
                }
                else
                {
                    _activeBuilding = null;
                    Debug.Log("None");
                }
            }
            else
            { 
                _activeBuilding = null;
                Debug.Log("None"); 
            }
            _uiHandler.UpdateUI();
        }
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
