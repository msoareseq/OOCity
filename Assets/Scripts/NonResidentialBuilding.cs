using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonResidentialBuilding : Building
{
    protected override void DoAction()
    {
        citizens = Random.Range(0, 20);
    }

    protected override void PayTaxes()
    {
        gameManager.AddCash(citizens * taxRate * 10);
    }
       
}
