using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    private GameManager gameManager;
    
    public GameObject buildingInfoPanel;
    public TextMeshProUGUI buildingNameText;
    public TextMeshProUGUI buildingTypeText;
    public TextMeshProUGUI buildingPopulationText;
    public TextMeshProUGUI buildingTaxRateText;
    public TextMeshProUGUI buildingNumberOfFloorsText;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void UpdateUI()
    {
        if (gameManager.ActiveBuilding != null)
        {
            buildingInfoPanel.SetActive(true);
            Building building = gameManager.ActiveBuilding.GetComponent<Building>();
            buildingNameText.text = building.BuildingName;
            buildingTypeText.text = building.TypeOfBuilding.ToString();
            buildingPopulationText.text = building.Citizens.ToString();
            buildingTaxRateText.text = building.TaxRate.ToString();
            buildingNumberOfFloorsText.text = building.NumberOfFloors.ToString();
        }
        else
        {
            buildingInfoPanel.SetActive(false);
        }
    }
}
