using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentialBuilding : Building
{
    protected override void DoAction()
    {
        citizens = Mathf.Clamp(citizens++, 0, 5);
    }

    protected override void PayTaxes()
    {
        gameManager.AddCash(citizens * taxRate * 100);
    }
        
}
