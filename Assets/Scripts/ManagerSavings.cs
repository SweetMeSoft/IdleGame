using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSavings : MonoBehaviour
{
    public Text txtSavings;
    public Button btnAskFor;
    public GameObject pnlUpgrades;

    public double baseValue;
    public double savings;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        btnAskFor.GetComponentInChildren<Text>().text = "Pedir +$ " + baseValue;
        txtSavings.text = "Savings: $ " + savings.ToString("0.00");
    }

    public void Click()
    {
        savings += baseValue;
    }

    public void OpenUpgrades()
    {
        pnlUpgrades.SetActive(true);
    }
}
