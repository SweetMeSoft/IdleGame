using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMaterial : MonoBehaviour
{
    ManagerSavings managerSavings;

    public Text txtMaterials;
    public Button btnBuyMaterial;

    public double quantityMaterial = 0;
    public double baseMaterial = 100;
    public double valueMaterial = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject managerObject = GameObject.Find("ManagerSavings");
        managerSavings = managerObject.GetComponent<ManagerSavings>();
    }

    // Update is called once per frame
    void Update()
    {
        txtMaterials.text = quantityMaterial+"m";
    }

    public void BuyMaterial()
    {
        if (managerSavings.savings >= valueMaterial)
        {
            quantityMaterial += baseMaterial;
            managerSavings.savings -= valueMaterial;
        }
    }
}
