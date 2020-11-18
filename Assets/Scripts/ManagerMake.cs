using UnityEngine;
using UnityEngine.UI;

public class ManagerMake : MonoBehaviour
{
    ManagerSavings managerSavings;
    ManagerMaterial managerMaterial;

    public Button btnMakeBracelet;
    public double valueMoney;
    public double costMaterial;

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
        if(managerMaterial.quantityMaterial < costMaterial)
        {
            btnMakeBracelet.enabled = false;
        }
        else
        {
            btnMakeBracelet.enabled = true;
        }
    }

    public void MakeBracelet()
    {
        if (managerMaterial.quantityMaterial >= costMaterial)
        {
            managerMaterial.quantityMaterial -= costMaterial;
            managerSavings.savings += valueMoney;
        }
    }
}
