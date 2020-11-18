using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMake : MonoBehaviour
{
    ManagerSavings managerSavings;
    ManagerMaterial managerMaterial;

    public Button btnMakeBracelet;
    public double braceletValue;
    public double baseMaterial;

    // Start is called before the first frame update
    void Start()
    {
        GameObject savings = GameObject.Find("ManagerSavings");
        GameObject material = GameObject.Find("ManagerMaterial");
        managerSavings = savings.GetComponent<ManagerSavings>();
        managerMaterial = material.GetComponent<ManagerMaterial>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeBracelet()
    {
        if (managerMaterial.quantityMaterial >= baseMaterial)
        {
            managerMaterial.quantityMaterial -= baseMaterial;
            managerSavings.savings += braceletValue;
        }
    }
}
